using LinList;
using System.Security.AccessControl;

namespace LeetCode.DS.BinarySearchTree;
internal class BST
{
    public BST_Node Root { get; private set; }
    public BST()
    {
        Root = null;
    }
    public void Insert(int val) {

        var newNode = new BST_Node(val);
        if (Root == null) {
            Root = newNode;
          
            return;
        }
        var current = Root;

        while (true) {

            if (val > current.Val)
            {
               
                if (current.Right == null) {
                    current.Right = newNode;
                    break;
                }
                current = current.Right;
            }
            if (val < current.Val)
            {
                if (current.Left == null)
                {
                    current.Left = newNode;
                    break;
                }
                current = current.Left;
            }
        }
    }
    public void InsertRec(int val)
    {
        Root = InsertRecursive(Root, val);
    }
    private BST_Node InsertRecursive(BST_Node node, int val)
    {
        // Base case: if the node is null, create a new node and return it
        if (node == null)
        {
            return new BST_Node(val);
        }

        // Recur down the tree
        if (val < node.Val)
        {
            node.Left = InsertRecursive(node.Left, val);
        }
        else if (val > node.Val)
        {
            node.Right = InsertRecursive(node.Right, val);
        }

        // Return the (unchanged) node pointer
        return node;
    }
    public List<int> BFS( ) {

        var node =Root;
        var data = new List<int> ();
        var queue = new Queue<BST_Node>();
        queue.Enqueue(node);
        while (queue.Count >0 ) {
          node = queue.Dequeue();
          data.Add(node.Val);
            if (node.Left != null )
                queue.Enqueue(node.Left);
            
            if (node.Right != null)
               queue.Enqueue(node.Right);
            
        }
        return data;
    }
    public BST_Node Search(int val)
    {

        if (Root ==null)
        {
            return null;
        }
        if (val == Root.Val)
        {
            return Root;
        }
        var current = Root;
        while (current.Left != null || current.Right != null) {
            if (val < current.Val) {
                if (val == current.Left.Val)
                {
                    return current.Left;
                }
                current =current.Left;
                continue;
            }
            if (val >current.Val)
            {
                if (val == current.Right.Val)
                {
                    return current.Right;
                }
                current = current.Right;
            }
        }
        return null;
    }
}
