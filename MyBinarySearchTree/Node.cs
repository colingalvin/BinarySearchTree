using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBinarySearchTree
{
    public class Node
    {
        // member variables
        public int value;
        public int count;
        public Node left;
        public Node right;

        // constructor
        public Node(int value)
        {
            this.value = value;
            count = 1;
            left = null;
            right = null;
        }

        // member methods
    }
}
