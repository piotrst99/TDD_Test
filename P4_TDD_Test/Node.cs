using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_TDD_Test {
    public class Node {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public int Data { get; set; }

        public Node() {

        }

        public Node(int value) {
            LeftNode = null;
            RightNode = null;
            Data = value;
        }
    }
}
