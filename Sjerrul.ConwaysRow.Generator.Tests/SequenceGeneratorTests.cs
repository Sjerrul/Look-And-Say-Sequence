using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Sjerrul.ConwaysRow.Generator.Tests
{
    [TestClass]
    public class SequenceGeneratorTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GenerateNextItem_EmptyString_Throws()
        {
            // Arrange
            IGenerate generator = new ConwaysRowGenerator();

            // Act
            string currentItem = string.Empty;
            generator.GenerateNextItem(currentItem);

            // Assert
            // ExpectedException
        }

        [TestMethod]
        public void GenerateNextItem_1_ReturnsCorrectNextItem()
        {
            // Arrange
            IGenerate generator = new ConwaysRowGenerator();

            // Act
            string currentItem = "1";
            string result = generator.GenerateNextItem(currentItem);

            // Assert
            Assert.AreEqual("11", result);
        }

        [TestMethod]
        public void GenerateNextItem_11_ReturnsCorrectNextItem()
        {
            // Arrange
            IGenerate generator = new ConwaysRowGenerator();

            // Act
            string currentItem = "11";
            string result = generator.GenerateNextItem(currentItem);

            // Assert
            Assert.AreEqual("21", result);
        }

        [TestMethod]
        public void GenerateNextItem_111_ReturnsCorrectNextItem()
        {
            // Arrange
            IGenerate generator = new ConwaysRowGenerator();

            // Act
            string currentItem = "111";
            string result = generator.GenerateNextItem(currentItem);

            // Assert
            Assert.AreEqual("31", result);
        }

        [TestMethod]
        public void GenerateNextItem_12_ReturnsCorrectNextItem()
        {
            // Arrange
            IGenerate generator = new ConwaysRowGenerator();

            // Act
            string currentItem = "12";
            string result = generator.GenerateNextItem(currentItem);

            // Assert
            Assert.AreEqual("1112", result);
        }

        [TestMethod]
        public void GenerateNextItem_112_ReturnsCorrectNextItem()
        {
            // Arrange
            IGenerate generator = new ConwaysRowGenerator();

            // Act
            string currentItem = "112";
            string result = generator.GenerateNextItem(currentItem);

            // Assert
            Assert.AreEqual("2112", result);
        }


        [TestMethod]
        public void GenerateNextItem_1122_ReturnsCorrectNextItem()
        {
            // Arrange
            IGenerate generator = new ConwaysRowGenerator();

            // Act
            string currentItem = "1122";
            string result = generator.GenerateNextItem(currentItem);

            // Assert
            Assert.AreEqual("2122", result);
        }

        [TestMethod]
        public void GenerateNextItem_112233_ReturnsCorrectNextItem()
        {
            // Arrange
            IGenerate generator = new ConwaysRowGenerator();

            // Act
            string currentItem = "112233";
            string result = generator.GenerateNextItem(currentItem);

            // Assert
            Assert.AreEqual("212223", result);
        }

        [TestMethod]
        public void GenerateNextItem_48334_ReturnsCorrectNextItem()
        {
            // Arrange
            IGenerate generator = new ConwaysRowGenerator();

            // Act
            string currentItem = "48334";
            string result = generator.GenerateNextItem(currentItem);

            // Assert
            Assert.AreEqual("14182314", result);
        }
    }
}
