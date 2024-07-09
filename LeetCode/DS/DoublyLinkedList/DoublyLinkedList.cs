
namespace LeetCode.DS.DoublyLinkedList;
internal class DoublyLinkedList
{
    public DoublyNode Head { get; set; }
    public DoublyNode Tail { get; set; }
    public int Length { get; set; }

    public DoublyLinkedList()
    {
        Head = null;
        Tail = null;
        Length = 0;
    }
    public void Push(int val)
    {
        var newNode = new DoublyNode(val);
        if (Length == 0)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            newNode.Prev = Tail;
            Tail = newNode;
        }
        Length++;
    }
    public void Pop()
    {
        if (Length == 0)
        {
            return;
        }
        var poppedNode = Tail;
        if (Length == 1)
        {
            Head = null;
            Tail = null;
            Length--;
        }
        else
        {
            Tail = Tail.Prev;
            Tail.Next = null;
            poppedNode.Prev = null;
        }
        Length--;

    }
    public void Shift()//remove the first item
    {
        if (Length == 0)
        {
            return;
        }
        var oldHead = Head;
        if (Length == 1)
        {
            Head = null;
            Tail = null;
        }
        else
        {
            Head = oldHead.Next;
            Head.Prev = null;
            oldHead.Next = null;
        }
        Length--;

    }
    public void UnShift(int val)//push in the first
    {
        var newNode = new DoublyNode(val);
        var oldHead = Head;
        if (Length ==0)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Head = newNode;
            Head.Next = oldHead;
            oldHead.Prev = newNode;
        }
        Length++;   
    }
    public void PrintList()
    {
        DoublyNode current = Head;
        while (current != null)
        {
            Console.WriteLine(current.Value.ToString());
            current = current.Next;
        }
    }

}
