using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Transactions;
using WorldGeography.DAL;
using WorldGeography.Models;

namespace WorldGeography.Tests
{
    [TestClass]
    public class LanguageSqlDAOTests 
    {
        protected string ConnectionString { get; } = "Server=.\\SQLEXPRESS;Database=World;Trusted_Connection=True;";

        /// <summary>
        /// The transaction for each test.
        /// </summary>
        private TransactionScope transaction;

        [TestInitialize]
        public void Setup()
        {
            // Begin the transaction
            transaction = new TransactionScope();
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Roll back the transaction
            transaction.Dispose();
        }

        [TestMethod]
        public void Test_RemoveLanguage_Result_and_Count()
        {
            // Arrange
            LanguageSqlDAO doa = new LanguageSqlDAO(ConnectionString);

            Language language = new Language();
            language.CountryCode = "USA";
            language.IsOfficial = false;
            language.Name = "C#";         

            doa.AddNewLanguage(language);
            int beforeDeleteCount = GetRowCount("countrylanguage");
           
            //ACTION
            bool result = doa.RemoveLanguage(language);
            int afterDeleteCount = GetRowCount("countrylanguage");

            // ASSERT
            Assert.IsTrue(result, "RemoveLanguage returned false");
            Assert.AreEqual(beforeDeleteCount-1 , afterDeleteCount, "Row count did not decrease.");


        }

        protected int GetRowCount(string table)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM {table}", conn);
                int count = (int)cmd.ExecuteScalar();
                return count;
            }
        }

    }
}
