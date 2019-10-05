using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.Classes;

namespace TDD.Tests.Classes
{
    [TestClass]
    public class KataRomanNumeralTests
    {
        KataRomanNumeral testClass;
        [TestInitialize]

        public void Initialize()
        {
            testClass = new KataRomanNumeral();

        }
        [TestMethod]
        public void test_M_for_thousand()
        {
            // KataRomanNumeral testClass = new KataRomanNumeral();

            string result = testClass.ConverToRomanNumeral(1000);

            Assert.AreEqual("M", result);

            result = testClass.ConverToRomanNumeral(2000);

            Assert.AreEqual("MM", result);

            result = testClass.ConverToRomanNumeral(3000);

            Assert.AreEqual("MMM", result);

            result = testClass.ConverToRomanNumeral(4000);

            Assert.AreEqual("MMMM", result);


        }
        [TestMethod]
        public void Test_D_for_five_Hundred()
        {

            string result = testClass.ConverToRomanNumeral(500);
            Assert.AreEqual("D", result);


            result = testClass.ConverToRomanNumeral(1500);
            Assert.AreEqual("MD", result);

        }




        [TestMethod]
        public void Test_C_for_hundred()
        {
            //KataRomanNumeral testClass = new KataRomanNumeral();

            string result = testClass.ConverToRomanNumeral(100);
            Assert.AreEqual("C", result);

            result = testClass.ConverToRomanNumeral(200);
            Assert.AreEqual("CC", result);

            result = testClass.ConverToRomanNumeral(1200);
            Assert.AreEqual("MCC", result);


        }

        [TestMethod]

        public void Test_L_for_fifty()
        {

            //KataRomanNumeral testClass = new KataRomanNumeral();

            string result = testClass.ConverToRomanNumeral(50);
            Assert.AreEqual("L", result);

            result = testClass.ConverToRomanNumeral(150);
            Assert.AreEqual("CL", result);

            result = testClass.ConverToRomanNumeral(1050);
            Assert.AreEqual("ML", result);

            result = testClass.ConverToRomanNumeral(1150);
            Assert.AreEqual("MCL", result);


        }
        [TestMethod]
        public void Test_X_for_ten()
        {
            string result = testClass.ConverToRomanNumeral(10);
            Assert.AreEqual("X", result);

            result = testClass.ConverToRomanNumeral(20);
            Assert.AreEqual("XX", result);

            result = testClass.ConverToRomanNumeral(120);
            Assert.AreEqual("CXX", result);

            result = testClass.ConverToRomanNumeral(1020);
            Assert.AreEqual("MXX", result);


        }

        [TestMethod]
        public void Test_V_for_five()
        {
            string result = testClass.ConverToRomanNumeral(5);
            Assert.AreEqual("V", result);

            result = testClass.ConverToRomanNumeral(15);
            Assert.AreEqual("XV", result);

            result = testClass.ConverToRomanNumeral(105);
            Assert.AreEqual("CV", result);

            result = testClass.ConverToRomanNumeral(1005);
            Assert.AreEqual("MV", result);


        }

        [TestMethod]
        public void Test_I_for_one()
        {
            string result = testClass.ConverToRomanNumeral(1);
            Assert.AreEqual("I", result);

            result = testClass.ConverToRomanNumeral(2);
            Assert.AreEqual("II", result);

            result = testClass.ConverToRomanNumeral(3);
            Assert.AreEqual("III", result);

            result = testClass.ConverToRomanNumeral(6);
            Assert.AreEqual("VI", result);


        }

        [TestMethod]
        public void ContractedForms()
        {
            string result = testClass.ConverToRomanNumeral(4);
            Assert.AreEqual("IV", result);

            result = testClass.ConverToRomanNumeral(400);
            Assert.AreEqual("CD", result);




        }
    }
}
