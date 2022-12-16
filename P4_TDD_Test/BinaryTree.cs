using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_TDD_Test {
    // klasa reprezentująca drzewo binarne
    public class BinaryTree {
        // obiekt reprezentujący root drzewa
        private Node _root { get; set; }

        // lista przechowyjąca posortowane wartości
        private List<int> list = new List<int>();

        // konstruktor  tworzący drzewo binarne
        public BinaryTree() {
            _root = null;
        }

        // metoda, czyszczaca drzewo w całości
        public void ClearTree() {
            _root = null;
        }

        // metoda zwraca informacje, czy jest puste
        public bool IsNull() {
            return _root == null;
        }

        // publiczna metoda do wstawiania elementu
        public void Insert(int value) {
            if (_root == null) {
                _root = new Node(value);
                return;
            }

            InsertData(_root, value);
        }

        // prywatna metoda to rekurencyjnego wstawiania elementu do drzewa binarnego
        // wykonujaca sie rekurencyjnie
        private void InsertData(Node parent, int value) {
            if (parent == null) {
                parent = new Node(value);
            }
            else if (value > parent.Data) {
                if (parent.RightNode == null) {
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

        // metoda zwracajaca minimalna wartosc drzewa binarnego, po wartosci
        public int? FindMinValue() {
            if(_root == null) {
                return null;
            }

            Node currentNode = _root;

            while (currentNode.LeftNode != null) {
                currentNode = currentNode.LeftNode;
            }

            return currentNode.Data;
        }

        // metoda zwracajaca minimalna wartosc drzewa binarnego, po galezi
        public int? FindMinValue(Node node) {
            Node currentNode = node;

            while (currentNode.LeftNode != null) {
                currentNode = currentNode.LeftNode;
            }

            return currentNode.Data;
        }

        // metoda zwracajaca maksymalna wartosc drzewa binarnego, po wartości
        public int? FindMaxValue() {
            if (_root == null) {
                return null;
            }

            Node currentNode = _root;

            while (currentNode.RightNode != null) {
                currentNode = currentNode.RightNode;
            }

            return currentNode.Data;
        }

        // funkcja, ktora zwraca posortowane drzewo do listy, wskazujac typ
        public List<int> SortBinaryTree(List<int> listToSort, string type) {
            if (listToSort.Count == 0 || listToSort == null) {
                return null;
            }

            list.Clear();
            ClearTree();

            foreach (var item in listToSort) {
                Insert(item);
            }

            SortTree(type);
            return list;
        }

        // funkcja zwracajaca całe drzewo
        public Node GetTree() {
            return _root;
        }

        // publiczna metoda sortujaca drzewo po rodzaju sortowania
        public void SortTree(string type) {
            SortTreeData(_root, type);
        }

        // prywatna metoda sortujaca drzewo, po galezi oraz rodzaju sortowania
        // wykonujaca sie rekurencyjnie
        private void SortTreeData(Node node, string type) {
            if (node == null) return;
            
            switch (type) {
                case "ASC":
                    SortTreeData(node.LeftNode, type);
                    list.Add(node.Data);
                    SortTreeData(node.RightNode, type);
                    break;
                case "DESC":
                    SortTreeData(node.RightNode, type);
                    list.Add(node.Data);
                    SortTreeData(node.LeftNode, type);
                    break;
                default:
                    break;
            }
        }

        // publiczna meoda zwracajaca sciezke do pierwszego wystapienia wartosci w drzewie binarnym
        public string FindPathToValue(int value) {
            if(_root == null) {
                return "Empty tree";
            }
            // used in console app
            //return $"Path to value {value} : {FindPathToValue(_root, value, ".")}";
            return FindPathToValue(_root, value, ".");
        }

        // prywatna meoda zwracajaca sciezke do pierwszego wystapienia wartosci w drzewie binarnym oraz podaniu galezi
        // wykonujaca sie rekurencyjnie
        private string FindPathToValue(Node node, int value, string path) {
            if (_root != null) {
                if(value == node.Data) {
                    return path;
                }
                if(value < node.Data) {
                    if (node.LeftNode == null) {
                        return "Path not found";
                    }
                    path += "L";
                    return FindPathToValue(node.LeftNode, value, path);
                }
                else {
                    if (node.RightNode == null) {
                        return "Path not found";
                    }
                    path += "R";
                    return FindPathToValue(node.RightNode, value, path);
                }
            }

            return path;
        }

        // publiczna metoda zwracajaca glebokosc drzewa
        public int GetTreeDepth() {
            return GetTreeDepth(_root);
        }

        // prywatna metoda zwracajaca glebokosc drzewa
        // wykonujaca sie rekurencyjnie
        private int GetTreeDepth(Node node) {
            return node == null ? 0 : Math.Max(GetTreeDepth(node.LeftNode), GetTreeDepth(node.RightNode)) + 1;
        }

        // usuwanie galezi
        public void RemoveValue(int value) {
            if (_root == null) return;
            _root = RemoveValue(_root, value);
        }

        // prywatna metoda usuwajaca i podstawijaca element estatni element z galezi podrzednej
        // wykonujaca sie rekurencyjnie
        private Node RemoveValue(Node node, int value) {
            if(node == null) {
                return node;
            }

            if(value < node.Data) {
                node.LeftNode = RemoveValue(node.LeftNode, value);
            }
            else if (value > node.Data){
                node.RightNode = RemoveValue(node.RightNode, value);
            }
            else {
                if(node.LeftNode == null) {
                    return node.RightNode;
                }
                else if (node.RightNode == null) {
                    return node.LeftNode;
                }

                node.Data = FindMinValue(node.RightNode).Value;
                node.RightNode = RemoveValue(node.RightNode, node.Data);
            }
            return node;
        }

        // display value in console
        private void DisplayTree(Node root, string symbol, char c) {
            if (root == null) return;

            DisplayTree(root.RightNode, "\t" + symbol, 'R');
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
            DisplayTree(root.LeftNode, "\t" + symbol, 'L');
            Console.ForegroundColor = ConsoleColor.White;
        }

        // display value in console
        public void DisplayTree() {
            DisplayTree(_root, "", 'O');
        }
    }
}