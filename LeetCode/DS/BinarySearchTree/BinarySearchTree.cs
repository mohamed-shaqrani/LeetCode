using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DS.BinarySearchTree
{
    internal class BinarySearchTree
    {
        public BSTNode Root;
        public BinarySearchTree()
        {
            Root = null;

        }
        public void Insert(int val)
        {
            var node = new BSTNode(val);
            if (Root == null)
            {
                Root = node;
            }
            else
            {
                var movedRoot = Root;

                while (true)
                {
                    if (val > movedRoot.Val)
                    {

                        //0  12 4 8  
                        if (movedRoot.Right == null)
                        {
                            movedRoot.Right = node;
                            break;
                        }

                        movedRoot = movedRoot.Right;
                        continue;
                    }
                   else if (val < movedRoot.Val)
                    {
                        if (movedRoot.Left == null)
                        {
                            movedRoot.Left = node;
                            break;
                        }
                        movedRoot = movedRoot.Left;
                        continue;
                    }
                    break;
                }

            }

        }
        private void PrintTree(BSTNode node)
        {
            if (node == null)
            {
                return;
            }

            // Traverse the left subtree
            PrintTree(node.Left);

            // Visit the root (print the value)
            Console.WriteLine(node.Val);

            // Traverse the right subtree
            PrintTree(node.Right);
        }

        // Public method to start the traversal from the root
        public void PrintTree()
        {
            PrintTree(Root);
        }
    }
}