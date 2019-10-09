using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Exercises.Tests
{
    [TestClass]
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

            Dictionary<string, int> expected1 = new Dictionary<string, int>();
            
            Dictionary<string, int> actual1 = testClass.GetCount(new string[] {});

            CollectionAssert.AreEqual(expected1, actual1);

            Dictionary<string, int> expected3 = new Dictionary<string, int>()
            {
               {"dog", 2 }, { "Zebra", 1 }, {"lion", 1}
            };


            Dictionary<string, int> actual3 = testClass.GetCount(new string[] { "dog", "Zebra", "dog", "lion" });

            CollectionAssert.AreEqual(expected3, actual3);



        }
        }
    }

