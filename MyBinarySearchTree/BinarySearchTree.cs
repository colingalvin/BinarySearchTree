using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBinarySearchTree
{
    public class BinarySearchTree
    {
        // member variables
        public Node root;

        // constructor
        public BinarySearchTree()
        {
            root = null;
        }

        // member methods
        public void Add(int value)
        {
            Node nodeToInsert = new Node(value); // Create new node with user input value
            if (root == null)
            {
                root = nodeToInsert; // Make root if root has not been established
                return;
            }
            else
            {
                bool hasBeenAdded = false;
                while (hasBeenAdded == false)
                {
                    Node currentNode = root; // Keep track of current node on tree
                    if (nodeToInsert.value == currentNode.value) // Check for duplicate values
                    {
                        currentNode.count++; // Increase count of current node if duplicate
                        hasBeenAdded = true; // Mark node as added
                    }
                    else // If value is not duplicate (of current node)
                    {
                        if (nodeToInsert.value < currentNode.value) // Value to insert less than current value - belongs to left
                        {
                            if (currentNode.left == null) // If left node is empty
                            {
                                currentNode.left = nodeToInsert; // Assign to left node
                                hasBeenAdded = true;
                            }
                            else // If left node is occupied
                            {
                                currentNode = currentNode.left; // Traverse to that node and repeat
                            }
                        }
                        else // Value to insert greater than current value - belongs to right
                        {
                            if (currentNode.right == null) // If right node is empty
                            {
                                currentNode.right = nodeToInsert; // Assign to right node
                                hasBeenAdded = true;
                            }
                            else
                            {
                                currentNode = currentNode.right; // Traverse to the node and repeat
                            }
                        }
                    }
                }
            }
        }

        public bool Search(int value)
        {
            bool treeContainsValue = false;
            Node currentNode = root; // Keep track of current node on tree
            while (treeContainsValue == false)
            {
                if (value == currentNode.value) // If input value matches value of node
                {
                    treeContainsValue = true; // Return true
                }
                else
                {
                    if (value < currentNode.value) // Check left node
                    {
                        if (currentNode.left == null)
                        {
                            break; // If node is null, break and return false
                        }
                        else
                        {
                            currentNode = currentNode.left; // Traverse to left and repeat
                        }
                    }
                    else // Check right node
                    {
                        if (currentNode.right == null)
                        {
                            break; // If node is null, break and return false
                        }
                        else
                        {
                            currentNode = currentNode.right; // Traverse to right and repeat
                        }
                    }
                }
            }
            return treeContainsValue;
        }
    }
}
