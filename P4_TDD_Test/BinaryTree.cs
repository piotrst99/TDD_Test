using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_TDD_Test {
    public class BinaryTree {
        private Node _root { get; set; }

        public BinaryTree() {
            _root = null;
        }

        public void Insert(int value) {
            if(_root == null) {
                _root = new Node(value);
                return;
            }

            InsertData(_root, value);
        }

        private void InsertData(Node parent, int value) {
            if(parent == null) {
                parent = new Node(value);
            }
            if(value > parent.Data) {
                if(parent.RightNode == null) {
                    parent.RightNode = new Node(value);
                }
                else {
                    InsertData(parent.RightNode, value);
                }
            }
            else {
                if (parent.LeftNode == null) {
                    parent.LeftNode = new Node(value);
                }
                else {
                    InsertData(parent.LeftNode, value);
                }
            }
        }

        private void DisplayTree(Node root) {
            if (root == null) return;

            DisplayTree(root.LeftNode);
            System.Console.Write(root.Data + " ");
            DisplayTree(root.RightNode);
        }

        private void DisplayTree(Node root, string symbol, char c) {
            if (root == null) return;

            DisplayTree(root.RightNode, "\t" + symbol,'R');
            if (c == 'O') {
                System.Console.Write(symbol + root.Data + "\n");
            }
            else if (c == 'R') {
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.Write(symbol + root.Data + "\n");
            }
            else {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.Write(symbol + root.Data + "\n");
            }
            DisplayTree(root.LeftNode, "\t"+symbol,'L');
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void DisplayTree() {
            DisplayTree(_root, "", 'O');
        }

        public void DrawBinaryTree() {

        }

        public bool IsNull() {
            return _root == null;
        }

        public Node GetTree() {
            return _root;
        }
    }
}
