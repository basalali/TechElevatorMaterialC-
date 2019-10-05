using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Exercises.Tests
{   [TestClass]
    public class FrontTimesTest
    {
        [TestMethod]
        public void GenerateStringTest()
        {

            FrontTimes testClass = new FrontTimes();

            string result = testClass.GenerateString("Techelevator", 3);

            Assert.AreEqual("TecTecTec", result);

            result = testClass.GenerateString("C#C#C#C#C#", 2);

            Assert.AreEqual("C#CC#C", result);



        }
        

    }
}
