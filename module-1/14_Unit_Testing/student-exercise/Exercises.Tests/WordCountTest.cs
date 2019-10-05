using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Exercises.Tests
{    [TestClass]
    public class WordCountTest
    {
        [TestMethod]
    public void GetCountTest()
        {
            WordCount testClass = new WordCount();

            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"Cow", 1 }, {"dog", 2 }, { "Zebra", 1 }, {"lion", 1}
            };

            Dictionary<string, int> actual = testClass.GetCount(new string[] { "Cow", "dog", "Zebra", "dog", "lion" });

            CollectionAssert.AreEqual(expected, actual);

        }
    }
}
