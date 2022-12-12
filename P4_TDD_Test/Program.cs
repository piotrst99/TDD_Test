using System;

namespace P4_TDD_Test {
    class Program {
        static void Main(string[] args) {
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
                binaryTree.Insert(new Random().Next(1, 200));
            }

            binaryTree.DisplayTree();
        }
    }
}
