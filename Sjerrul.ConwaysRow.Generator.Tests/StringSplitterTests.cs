using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Sjerrul.ConwaysRow.Generator.Tests
{
    [TestClass]
    public class StringSplitterTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Split_EmptyString_Throws()
        {
            // Arrange
            string input = string.Empty;

            // Act
            StringSplitter.SplitInGroups(input);

            // Assert
            // ExpectedException
        }

        [TestMethod]
        public void Test1()
        {
            // Arrange
            string input = "1";

            // Act
            IList<string> result = StringSplitter.SplitInGroups(input);

            // Assert
            IList<string> expected = new List<string>
            {
                "1"
            };

            Assert.IsTrue(AreArraysEqual(expected, result));
        }

        [TestMethod]
        public void Test11()
        {
            // Arrange
            string input = "11";

            // Act
            IList<string> result = StringSplitter.SplitInGroups(input);
            
            // Assert
            IList<string> expected = new List<string>
            {
                "11"
            };

            Assert.IsTrue(AreArraysEqual(expected, result));
        }

        [TestMethod]
        public void Test111()
        {
            // Arrange
            string input = "111";

            // Act
            IList<string> result = StringSplitter.SplitInGroups(input);

            // Assert
            IList<string> expected = new List<string>
            {
                "111"
            };

            Assert.IsTrue(AreArraysEqual(expected, result));
        }

        [TestMethod]
        public void Test12()
        {
            // Arrange
            string input = "12";

            // Act
            IList<string> result = StringSplitter.SplitInGroups(input);

            // Assert
            IList<string> expected = new List<string>
            {
                "1",
                "2"
            };

            Assert.IsTrue(AreArraysEqual(expected, result));
        }

        [TestMethod]
        public void Test112()
        {
            // Arrange
            string input = "112";

            // Act
            IList<string> result = StringSplitter.SplitInGroups(input);

            // Assert
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
            // Arrange
            string input = "1122";

            // Act
            IList<string> result = StringSplitter.SplitInGroups(input);

            // Assert
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
            // Arrange
            string input = "112233";

            // Act
            IList<string> result = StringSplitter.SplitInGroups(input);

            // Assert
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
            // Arrange
            string input = "11223311";

            // Act
            IList<string> result = StringSplitter.SplitInGroups(input);

            // Assert
            IList<string> expected = new List<string>
            {
                "11",
                "22",
                "33",
                "11"
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

    }
}
