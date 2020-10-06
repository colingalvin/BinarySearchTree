using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyBinarySearchTree;

namespace UnitTests
{
    [TestClass]
    public class SearchTests
    {
        [TestMethod] // Test 1
        public void Search_Add25_Search25_ReturnTrue()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();
            bool expected = true;
            bool actual;

            // Act
            tree.Add(25);
            actual = tree.Search(25);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 2
        public void Search_Add25_Search20_ReturnFalse()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();
            bool expected = false;
            bool actual;

            // Act
            tree.Add(25);
            actual = tree.Search(20);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 3
        public void Search_Add25_20_30_Search20_ReturnTrue()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();
            bool expected = true;
            bool actual;

            // Act
            tree.Add(25);
            tree.Add(20);
            tree.Add(30);
            actual = tree.Search(20);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 4
        public void Search_Add25_20_30_Search35_ReturnFalse()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();
            bool expected = false;
            bool actual;

            // Act
            tree.Add(25);
            tree.Add(20);
            tree.Add(30);
            actual = tree.Search(35);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
