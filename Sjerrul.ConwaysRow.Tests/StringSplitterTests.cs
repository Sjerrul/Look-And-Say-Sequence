using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Sjerrul.ConwaysRow.Tests
{
    [TestClass]
    public class StringSplitterTests
    {
        [TestMethod]
        public void Test1()
        {
            string input = "1";

            IList<string> result = StringSplitter.Split(input);
            IList<string> expected = new List<string>
            {
                "1"
            };

            Assert.IsTrue(AreArraysEqual(expected, result));
        }

        [TestMethod]
        public void Test11()
        {
            string input = "11";

            IList<string> result = StringSplitter.Split(input);
            IList<string> expected = new List<string>
            {
                "11"
            };

            Assert.IsTrue(AreArraysEqual(expected, result));
        }

        [TestMethod]
        public void Test111()
        {
            string input = "111";

            IList<string> result = StringSplitter.Split(input);
            IList<string> expected = new List<string>
            {
                "111"
            };

            Assert.IsTrue(AreArraysEqual(expected, result));
        }

        [TestMethod]
        public void Test12()
        {
            string input = "12";

            IList<string> result = StringSplitter.Split(input);
            IList<string> expected = new List<string>
            {
                "1",
                "2"
            };

            Assert.IsTrue(AreArraysEqual(expected, result));
        }

        private bool AreArraysEqual(IList<string> array1, IList<string> array2)
        {
            if (array1.Count != array2.Count)
            {
                return false;
            }

            for (int i = 0; i < array1.Count; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }

        [TestMethod]
        public void Test112()
        {
            string input = "112";

            IList<string> result = StringSplitter.Split(input);
            IList<string> expected = new List<string>
            {
                "11",
                "2"
            };

            Assert.IsTrue(AreArraysEqual(expected, result));
        }

        [TestMethod]
        public void Test1122()
        {
            string input = "1122";

            IList<string> result = StringSplitter.Split(input);
            IList<string> expected = new List<string>
            {
                "11",
                "22"
            };

            Assert.IsTrue(AreArraysEqual(expected, result));
        }

        [TestMethod]
        public void Test112233()
        {
            string input = "112233";

            IList<string> result = StringSplitter.Split(input);
            IList<string> expected = new List<string>
            {
                "11",
                "22",
                "33"
            };

            Assert.IsTrue(AreArraysEqual(expected, result));
        }

        [TestMethod]
        public void Test11223311()
        {
            string input = "11223311";

            IList<string> result = StringSplitter.Split(input);
            IList<string> expected = new List<string>
            {
                "11",
                "22",
                "33",
                "11"
            };

            Assert.IsTrue(AreArraysEqual(expected, result));
        }
        
    }
}
