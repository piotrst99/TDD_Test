using NUnit.Framework;
using P4_TDD_Test;
using System.Collections.Generic;

namespace TDD_Test {
    [TestFixture]
    public class TDD_ClassTest {
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
            var result = binaryTree.IsNull();
            Assert.AreNotEqual(result, true);
        }

        [Test]
        public void FindMinValue_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(10);
            binaryTree.Insert(3);
            binaryTree.Insert(15);
            binaryTree.Insert(2);
            binaryTree.Insert(9);
            var result = binaryTree.FindMinValue();
            Assert.AreEqual(result, 2);
            Assert.AreNotEqual(result, 15);
            Assert.AreNotEqual(result, null);
        }

        [Test]
        public void FindMinValue_NullList_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            var result = binaryTree.FindMinValue();
            Assert.AreEqual(result, null);
        }

        [Test]
        public void FindMaxValue_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(10);
            binaryTree.Insert(3);
            binaryTree.Insert(15);
            binaryTree.Insert(2);
            binaryTree.Insert(9);
            binaryTree.Insert(100);
            binaryTree.Insert(-50);
            var result = binaryTree.FindMaxValue();
            Assert.AreEqual(result, 100);
            Assert.AreNotEqual(result, -50);
            Assert.AreNotEqual(result, null);
        }

        [Test]
        public void FindMaxValue_NullList_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            var result = binaryTree.FindMaxValue();
            Assert.AreEqual(result, null);
        }

        [Test]
        public void SortTreeASC_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            List<int> list = new List<int>() { 7, 20, 3, 0, -1 };
            List<int> listResult = new List<int>() { -1, 0, 3, 7, 20 };
            var result = binaryTree.SortBinaryTree(list, "ASC");
            Assert.AreEqual(result, listResult);
            Assert.AreNotEqual(result, list);
        }

        [Test]
        public void SortTreeDESC_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            List<int> list = new List<int>() { 7, 20, 3, 0, -1 };
            List<int> listResult = new List<int>() { 20, 7, 3, 0, -1 };
            var result = binaryTree.SortBinaryTree(list, "DESC");
            Assert.AreEqual(result, listResult);
            Assert.AreNotEqual(result, list);
        }

        [Test]
        public void ClearBinaryTree_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(10);
            binaryTree.Insert(3);
            binaryTree.Insert(15);
            Assert.AreEqual(binaryTree.IsNull(), false);
            binaryTree.ClearTree();
            Assert.AreEqual(binaryTree.IsNull(), true);
            Assert.AreNotEqual(binaryTree.IsNull(), false);
        }

        [Test]
        public void FindPathToValue_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            var list = new List<int> { 8, 3, 10, 1, 6, 14, 4, 7, 13 };
            foreach (var item in list) {
                binaryTree.Insert(item);
            }

            Assert.AreEqual(binaryTree.FindPathToValue(13), ".RRL");
            Assert.AreEqual(binaryTree.FindPathToValue(-1), "Path not found");
            Assert.AreEqual(binaryTree.FindPathToValue(4), ".LRL");
            Assert.AreEqual(binaryTree.FindPathToValue(8), ".");
            Assert.AreEqual(binaryTree.FindPathToValue(100), "Path not found");
            Assert.AreNotEqual(binaryTree.FindPathToValue(8), "Empty tree");
        }

        [Test]
        public void FindPathToValue_EmptyTree_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();

            Assert.AreEqual(binaryTree.FindPathToValue(-1), "Empty tree");
            Assert.AreEqual(binaryTree.FindPathToValue(0), "Empty tree");
        }

        [Test]
        public void GetTreeDepth_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            var list = new List<int> { 8, 3, 10, 1, 6 };
            foreach (var item in list) {
                binaryTree.Insert(item);
            }

            Assert.AreEqual(binaryTree.GetTreeDepth(), 3);
            binaryTree.Insert(7);
            Assert.AreEqual(binaryTree.GetTreeDepth(), 4);
            binaryTree.Insert(14);
            Assert.AreEqual(binaryTree.GetTreeDepth(), 4);
            Assert.AreNotEqual(binaryTree.GetTreeDepth(), 0);
        }

        [Test]
        public void GetTreeDepth_EmptyTree_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            Assert.AreEqual(binaryTree.GetTreeDepth(), 0);
        }

        [Test]
        public void RemoveValue_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.RemoveValue(10);
            Assert.AreEqual(binaryTree.GetTree(), null);
        }

        [Test]
        public void RemoveValue_EmptyTree_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            var list = new List<int> { 8, 3, 10, 1, 6, 14, 4 };
            foreach (var item in list) {
                binaryTree.Insert(item);
            }

            binaryTree.RemoveValue(3);
            var result = binaryTree.SortBinaryTree(list, "ASC");
            var exceptedResult = new List<int> { 8, 4, 10, 1, 6, 14 };
            Assert.AreNotEqual(result, exceptedResult);
            Assert.AreNotEqual(binaryTree.GetTree(), null);
        }

        [Test]
        public void RemoveValue_RemoveAllData_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            var list = new List<int> { 8, 3, 10, 1 };
            foreach (var item in list) {
                binaryTree.Insert(item);
            }

            binaryTree.RemoveValue(1);
            binaryTree.RemoveValue(3);
            binaryTree.RemoveValue(8);
            binaryTree.RemoveValue(10);
            Assert.AreEqual(binaryTree.GetTree(), null);
        }
    }
}
