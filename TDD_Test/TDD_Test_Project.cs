using NUnit.Framework;
using P4_TDD_Test;
using System.Collections.Generic;

namespace TDD_Test {
    [TestFixture]
    public class TDD_Test_Project {
        [Test]
        public void CreateBinaryTree_ShouldBeNull() {
            BinaryTree binaryTree = new BinaryTree();
            var result = binaryTree.IsNull();
            Assert.AreEqual(result, true);
        }

        [Test]
        public void CreateBinaryTree_ShouldNotBeNull() {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(10);
            binaryTree.Insert(4);
            var result = binaryTree.IsNull();
            Assert.AreNotEqual(result, true);
        }

        [Test]
        public void FindMinValue_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(4);
            binaryTree.Insert(1);
            var result = binaryTree.FindMinValue();
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void FindPathToValue_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            var list = new List<int> { 8, 3, 10, 4 };
            foreach (var item in list) {
                binaryTree.Insert(item);
            }

            Assert.AreEqual(binaryTree.FindPathToValue(4), ".LR");
            Assert.AreEqual(binaryTree.FindPathToValue(-1), "Path not found");
        }
    }
}
