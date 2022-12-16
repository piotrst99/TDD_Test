using NUnit.Framework;
using P4_TDD_Test;
using System.Collections.Generic;

namespace TDD_Test {
    [TestFixture]
    public class TDD_ClassTest {
        // metoda testujaca tworzenie drzewa binarnego i sprawdza czy jest pusta
        [Test]
        public void CreateBinaryTree_ShouldBeNull() {
            BinaryTree binaryTree = new BinaryTree();
            var result = binaryTree.IsNull();
            Assert.AreEqual(result, true);
        }

        // metoda testujaca tworzenie drzewa binarnego, dodaje element i sprawdza czy nie jest pusta
        [Test]
        public void CreateBinaryTree_ShouldNotBeNull() {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(10);
            var result = binaryTree.IsNull();
            Assert.AreNotEqual(result, true);
        }

        // metoda testujaca wyszukanie minimalnej wartosci w drzewie binarnym
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

        // metoda testujaca wyszukanie minimalnej wartosci w pustym drzewie binarmym
        [Test]
        public void FindMinValue_NullList_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            var result = binaryTree.FindMinValue();
            Assert.AreEqual(result, null);
        }

        // metoda testujaca wyszukanie maksymalnej wartosci drzewie binarnym
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

        // metoda testujaca wyszukanie maksymalnej wartosci w pustym drzewie binarmym
        [Test]
        public void FindMaxValue_NullList_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            var result = binaryTree.FindMaxValue();
            Assert.AreEqual(result, null);
        }

        // metoda testujaca sortowania wartosci drzewa w kolejnosci rosnacej
        [Test]
        public void SortTreeASC_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            List<int> list = new List<int>() { 7, 20, 3, 0, -1 };
            List<int> listResult = new List<int>() { -1, 0, 3, 7, 20 };
            var result = binaryTree.SortBinaryTree(list, "ASC");
            Assert.AreEqual(result, listResult);
            Assert.AreNotEqual(result, list);
        }

        // metoda testujaca sortowania wartosci drzewa w kolejnosci malejacej
        [Test]
        public void SortTreeDESC_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            List<int> list = new List<int>() { 7, 20, 3, 0, -1 };
            List<int> listResult = new List<int>() { 20, 7, 3, 0, -1 };
            var result = binaryTree.SortBinaryTree(list, "DESC");
            Assert.AreEqual(result, listResult);
            Assert.AreNotEqual(result, list);
        }

        // metoda testujaca czyszczenie całego drzewa binarnego
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

        // metoda testujaca przeszukanie scieski do pierwszego wystapienia elemetu w drzewie binarnym
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

        // metoda testujaca przeszukanie scieski do pierwszego wystapienia elemetu w pustym drzewie binarnym
        [Test]
        public void FindPathToValue_EmptyTree_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();

            Assert.AreEqual(binaryTree.FindPathToValue(-1), "Empty tree");
            Assert.AreEqual(binaryTree.FindPathToValue(0), "Empty tree");
        }

        // metoda testuje obliczenie glebokosci drzewa binarnego
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

        // metoda testuje obliczenie glebokosci pustego drzewa binarnego
        [Test]
        public void GetTreeDepth_EmptyTree_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            Assert.AreEqual(binaryTree.GetTreeDepth(), 0);
        }

        // metoda tesujaca usuwanie wartosci z drzewa binarnego, oraz wstawia jego podrzedny element z ostatniej galezi
        [Test]
        public void RemoveValue_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.RemoveValue(10);
            Assert.AreEqual(binaryTree.GetTree(), null);
        }

        // metoda tesujaca usuwanie wartosci z pustego drzewa binarnego
        [Test]
        public void RemoveValue_EmptyTree_ShouldBeCorrect() {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.RemoveValue(3);
            Assert.AreEqual(binaryTree.GetTree(), null);
        }

        // metoda tesujaca usuwanie calego drzewa binarnego w dowolnej kolejnosci
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
