using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Exercises.Tests
{   [TestClass]
    public class Less20Test
    {
        [TestMethod]
        public void IsLessThanMultiple20Test()
        {
            Less20 testClass = new Less20();

            bool result = testClass.IsLessThanMultipleOf20(399);
            Assert.AreEqual(true, result);

            result = testClass.IsLessThanMultipleOf20(398);
            Assert.AreEqual(true, result);

            result = testClass.IsLessThanMultipleOf20(320);
            Assert.AreEqual(false, result);

        }



    }
}
