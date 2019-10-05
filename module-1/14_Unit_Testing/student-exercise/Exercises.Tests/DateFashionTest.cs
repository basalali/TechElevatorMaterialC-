using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTest
    {
        [TestMethod]
        public void GetATable()
        {
            DateFashion fashion = new DateFashion();

            int result = fashion.GetATable(0, 10);
            Assert.AreEqual(0, result);

             result = fashion.GetATable(8, 8);
            Assert.AreEqual(2, result);

             result = fashion.GetATable(5, 5);
            Assert.AreEqual(1, result);

            

       
        }
    }
}
