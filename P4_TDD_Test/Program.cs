using System;
using System.Collections.Generic;

namespace P4_TDD_Test {
    class Program {
        static void Main() {
            /*BinaryTree binaryTree = new BinaryTree();
            Console.WriteLine(binaryTree.IsNull());
            BinaryTree binaryTree2 = new BinaryTree(10);
            Console.WriteLine(binaryTree2.IsNull());
            Console.WriteLine(binaryTree2.Root.Data);
            binaryTree.AddValue(5);
            Console.WriteLine(binaryTree2.Root.LeftNode.Data);*/
            //Console.WriteLine(binaryTree2.Root.RightNode.Data);

            BinaryTree binaryTree = new BinaryTree();
            /*Console.WriteLine(binaryTree.IsNull());
            binaryTree.Insert(10);
            Console.WriteLine(binaryTree.IsNull());
            Console.WriteLine(binaryTree.GetTree().Data);
            binaryTree.Insert(20);
            Console.WriteLine(binaryTree.GetTree().RightNode.Data);
            binaryTree.Insert(15);
            Console.WriteLine(binaryTree.GetTree().RightNode.LeftNode.Data);*/
            /*binaryTree.Insert(25);
            binaryTree.Insert(30);
            binaryTree.Insert(27);
            binaryTree.Insert(5);
            binaryTree.Insert(3);
            binaryTree.Insert(4);
            binaryTree.Insert(33);
            binaryTree.Insert(22);
            binaryTree.Insert(18);
            binaryTree.Insert(12);
            binaryTree.Insert(-1);
            binaryTree.Insert(2);
            binaryTree.Insert(40);
            binaryTree.Insert(40);
            binaryTree.Insert(19);
            binaryTree.Insert(7);
            binaryTree.Insert(6);
            binaryTree.Insert(5);
            binaryTree.Insert(17);*/

            for (int i = 0; i < 25; i++) {
                binaryTree.Insert(new Random().Next(1, 500));
            }

            binaryTree.DisplayTree();

            Console.WriteLine(binaryTree.IsNull());
            binaryTree.ClearTree();
            Console.WriteLine(binaryTree.IsNull());
            Console.WriteLine("------------------------------------------------------------------------------");

            for (int i = 0; i < 25; i++) {
                binaryTree.Insert(new Random().Next(1, 500));
            }
            binaryTree.DisplayTree();

            Console.WriteLine($"Min value in tree: {binaryTree.FindMinValue()}");
            Console.WriteLine($"Max value in tree: {binaryTree.FindMaxValue()}");

            //binaryTree.SortBinaryTree(,"ASC");

            BinaryTree binaryTree2 = new BinaryTree();
            var list = new List<int> { 4, 6, 5, 3, 2, 1, };
            var test = binaryTree2.SortBinaryTree(list, "ASC");
            foreach (var item in test) {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            var test2 = binaryTree2.SortBinaryTree(list, "DESC");
            foreach (var item in test) {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            BinaryTree binaryTree3 = new BinaryTree();
            var list2 = new List<int> { 8, 3, 10, 1, 6, 14, 4, 7, 13 };
            foreach (var item in list2) {
                binaryTree3.Insert(item);
            }
            Console.WriteLine(binaryTree3.FindPathToValue(13));
            Console.WriteLine(binaryTree3.FindPathToValue(8));
            Console.WriteLine(binaryTree3.FindPathToValue(1));
            Console.WriteLine(binaryTree3.FindPathToValue(0));
            Console.WriteLine(binaryTree3.FindPathToValue(15));
            Console.WriteLine(binaryTree3.FindPathToValue(4));
            Console.WriteLine(binaryTree3.FindPathToValue(9));
            Console.WriteLine(binaryTree3.FindPathToValue(14));
            Console.WriteLine(binaryTree3.FindPathToValue(100));
            
            Console.WriteLine();
            binaryTree3.DisplayTree();

            Console.WriteLine("------------------------------------------------------------------------------"); 
            binaryTree3.RemoveValue(14);
            binaryTree3.DisplayTree();

            Console.WriteLine("------------------------------------------------------------------------------");
            binaryTree3.RemoveValue(6);
            binaryTree3.DisplayTree();

            Console.WriteLine("------------------------------------------------------------------------------");
            binaryTree3.RemoveValue(8);
            binaryTree3.DisplayTree();

            Console.WriteLine("------------------------------------------------------------------------------");
            binaryTree3.RemoveValue(7);
            binaryTree3.DisplayTree();
        }
    }
}   
