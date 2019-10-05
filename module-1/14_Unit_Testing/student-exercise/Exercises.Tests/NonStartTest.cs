using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Exercises.Tests
{   [TestClass]
    public class NonStartTest
    {
        [TestMethod]
       public void GetPartialStringTest()
        {
            NonStart testClass = new NonStart();

            string actual = testClass.GetPartialString("Tech", "Elevator");

            Assert.AreEqual("echlevator", actual);

            actual = testClass.GetPartialString("Iiloveto", "Ccode");

            Assert.AreEqual("ilovetocode", actual);

           
        }



    }
}
