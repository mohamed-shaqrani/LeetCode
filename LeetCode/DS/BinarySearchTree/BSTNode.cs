namespace LeetCode.DS.BinarySearchTree;
internal class BSTNode
{
    public BSTNode Left { get; set; }
    public BSTNode Right { get; set; }
    public int Val { get; set;}
    public BSTNode(int value)
    {
           Val = value;
           Left = null;
           Right = null;
    }
}
