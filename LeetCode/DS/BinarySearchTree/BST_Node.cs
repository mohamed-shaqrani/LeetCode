using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DS.BinarySearchTree;
internal class BST_Node
{
    public BST_Node Left {  get; set; }
    public BST_Node Right { get; set; }
    public static BST_Node Root {  get; set; }
    public int Val { get; set; }
    public BST_Node(int val)
    {
        Val = val;
        Left = null;
        Right = null;

    }
}
