using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Exercises.Tests
{   [TestClass]
    public class MaxEnd3Test
    {
        [TestMethod]

        public void MakeArrayTest()
        {

            MaxEnd3 testClass = new MaxEnd3();

            int[] result = testClass.MakeArray(new int[] { 533, 24, 42 });

            CollectionAssert.AreEqual(new int[] { 533, 533, 533 }, result);

             result = testClass.MakeArray(new int[] { 523, 214, 4244 });

            CollectionAssert.AreEqual(new int[] { 4244, 4244, 4244 }, result);





        }


    }
}
