using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyBinarySearchTree;

namespace UnitTests
{
    [TestClass]
    public class AddTests
    {
        [TestMethod] // Test 1
        public void Add_EmptyTree_AddValue25_ValueAssignedToRoot()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();
            int expected = 25;
            int actual;

            // Act
            tree.Add(25);
            actual = tree.root.value;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 2
        public void Add_RootIs25_AddDuplicateValue_RootCountIs2()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();
            int expected = 2;
            int actual;

            // Act
            tree.Add(25);
            tree.Add(25);
            actual = tree.root.count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 3
        public void Add_RootIs25_AddValueOf20_RootLeftChildIs20()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();
            int expected = 20;
            int actual;

            // Act
            tree.Add(25);
            tree.Add(20);
            actual = tree.root.left.value;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 4
        public void Add_RootIs25_AddValueof30_RootRightChildIs30()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();
            int expected = 30;
            int actual;

            // Act
            tree.Add(25);
            tree.Add(30);
            actual = tree.root.right.value;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
