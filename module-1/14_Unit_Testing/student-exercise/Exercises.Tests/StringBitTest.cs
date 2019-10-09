using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{       [TestClass]
   public class StringBitTest
    {
        [TestMethod]
    public void GetBitsTest()
        {
            StringBits testClass = new StringBits();

            string actual = testClass.GetBits("Horses");
            Assert.AreEqual("Hre", actual);

             actual = testClass.GetBits("qwertyuiop");
            Assert.AreEqual("qetuo", actual);

            actual = testClass.GetBits("");
            Assert.AreEqual("", actual);


        }





    }
}
