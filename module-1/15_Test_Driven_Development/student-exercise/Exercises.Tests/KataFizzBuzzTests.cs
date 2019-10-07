
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataFizzBuzzTests
    {
        KataFizzBuzz testFizzBuzz;

        [TestInitialize]
        public void Initialize()
        {
            testFizzBuzz = new KataFizzBuzz();
        }

        [TestMethod]
        public void Method_exists_test()
        {

        }

        [TestMethod]
        public void FizzBuzz3_15_test()
        {

            string expected = testFizzBuzz.FizzBuzz(15);
            Assert.AreEqual("FizzBuzz", expected);

            expected = testFizzBuzz.FizzBuzz(60);
            Assert.AreEqual("FizzBuzz", expected);

        }

        [TestMethod]
        public void Buzz_test()
        {

            string expected = testFizzBuzz.FizzBuzz(10);
            Assert.AreEqual("Buzz", expected);

            expected = testFizzBuzz.FizzBuzz(25);
            Assert.AreEqual("Buzz", expected);

        }




    }
}
