using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Exercises.Tests
{
    [TestClass]
   public class SameFirstLastTest
    {
        [TestMethod]
       public void IsItTheSameTest()
        {

            SameFirstLast testClass = new SameFirstLast();


            bool actual = testClass.IsItTheSame(new int[] {1, 2, 3, 44, 2, 1 });

            Assert.AreEqual(true, actual);

            actual = testClass.IsItTheSame(new int[] { 1, 6, 8, 43, 7, 10 });

            Assert.AreEqual(false, actual);

            actual = testClass.IsItTheSame(new int[] {});

            Assert.AreEqual(false, actual);



        }




    }
}
