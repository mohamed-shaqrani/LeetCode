using LinList;
namespace LeetCode.DS;
public class SingleLinkedList
{
    public Node Head { get; private set; }
    public Node Tail { get; private set; }
    public int Length { get; private set; }

    public void Shift()//remove the last node 
    {

        if (Head == null)
        {
            return;
        }
        if (Head == Tail)
        {
            Head = null;
            Tail = null;
            return;
        }
        else
        {
            Head = Head.Next;


        }
        Length--;

    }
    public void Traverse()
    {
        if (Head == null)
        {
            return;
        }
        if (Head == Tail)
        {
            Head = null;
            Tail = null;
            return;
        }
        else
        {
            Node current = Head;
            while (current.Next != Tail)
            {
                current = current.Next;
            }
            Tail = current;
            current.Next = null;

        }
        Length--;



    }
    public void Push(int val)
    {
        var node = new Node(val);
        if (Head == null)
        {
            Head = node;
            Tail = node;

        }
        else
        {
            Tail.Next = node;
            Tail = node;
        }
        Length++;
    }
    public override string ToString()
    {
        return $"tail{Tail.Value} head{Head.Value}";
    }
    public void PrintList()
    {
        Node current = Head;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;

        }
    }
    public void Unshift(int val)
    {
        var node = new Node(val);
        if (Head == null)
        {

            Head = node;
            Tail = Head;
            Head.Next = null;

        }
        else
        {
            var temp = Head;
            Head = node;
            Head.Next = temp;
        }
        Length++;

    }
    public bool Set(int index, int val)
    {
        if (index > Length || Length < 0)
        {
            return false;
        }
        Node node = Head;
        for (int i = 0; i < index; i++)
        {
            node = node.Next;
        }
        node.Value = val;
        return true;
    }
    public void InsertAt(int index, int val)
    {
        if (index > Length || index < 0)
        {
            return;
        }
        if (index == Length)
        {
            Push(val);
            return;
        }
        if (index == 0)
        {
            Unshift(val);
            return;
        }
        Node nodeBefore = Head;
        for (int i = 0; i < index - 1; i++) // Traverse to the node before the insertion point
        {
            nodeBefore = nodeBefore.Next;
        }

        var newNode = new Node(val);
        newNode.Next = nodeBefore.Next; // Link the new node to the next node
        nodeBefore.Next = newNode; // Link the previous node to the new node

    }
    public void RemoveAt(int index)
    {
        if (index > Length || index < 0)
        {
            return;
        }
        if (index == 0)
        {
            Shift();
            return;
        }
        if (index == Length - 1)
        {
            Pop();
            return;
        }
        for (int i = 1; i < Length; i++)
        {
            Node node = Head;

            if (i == index)
            {
                node.Next = node.Next.Next;

            }

        }

    }
    public void Pop()
    {

        Node node = Head;
        while (node.Next != Tail)
        {
            node = node.Next;

        }
        Tail = node;
        node.Next = null;
    }
    public int Get(int index)
    {
        if (index > Length || Length < 0)
        {
            throw new Exception();
        }
        var node = Head;
        for (int i = 0; i < Length; i++)
        {
            node = node.Next;
            if (index == i)
            {
                Console.WriteLine(node.Value);

                return node.Value;
            }
        }
        throw new Exception();
    }
    public void Reverse()
    {
        if (Length == 0)
        {

            return;
        }
        var tailVal = Tail.Value;
        Tail = Head;
        var temp = Head.Next;
        var secTemp = Head.Next.Next;
        var temptail = Tail;
        Tail.Next = null;
        while (tailVal != Head.Value)
        {

            temp.Next = temptail;
            temptail = temp;
            if (secTemp.Next == null)
            {
                secTemp.Next = temptail;
                Head = secTemp;
            }
            else
            {
                temp = secTemp;
                secTemp = secTemp.Next;
            }


        }

    }

}

