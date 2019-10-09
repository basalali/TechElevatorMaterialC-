using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Exercises.Tests
{       [TestClass]
    public class Lucky13Test
    {
        [TestMethod]
        public void GetLuckyTest()
        {

            Lucky13 testClass = new Lucky13();



            bool result = testClass.GetLucky(new int[] { 5, 3, 2});
            Assert.AreEqual(false, result);

             result = testClass.GetLucky(new int[] { 4, 5, 10 });
            Assert.AreEqual(true, result);

            result = testClass.GetLucky(new int[] { 4, 3, 7 });
            Assert.AreEqual(false, result);

            result = testClass.GetLucky(new int[] {});
            Assert.IsTrue(result);



        }




    }
}
