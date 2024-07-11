
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
            //better solution by gpt
            //newNode.Next = Head;
            //Head.Prev = newNode;
            //Head = newNode;

        }
        Length++;   
    }
    public DoublyNode Get( int index)
    {
        if( Length == 0 || index>= Length)
           return null;
         
        var mid = Length / 2;//20  10 11

        if (index <= mid)
        {
            var tempHead = Head;
            for (int i = 0; i <= mid; i++)
            {
               
                if (i == index)
                {
                    
                    return tempHead;
                }
                tempHead = tempHead.Next;
            }

        }
        else
        {
            var tempTail  = Tail;
            for (decimal i = Length-1; i >= index; i--)
            {
                if (i == index)
                {
                    
                    return tempTail;
                }
                tempTail = tempTail.Prev;
            }

        }
        return  null;
    }
    public bool Set(int index, int value )
    {
        var node =Get(index);
        if( node == null)
          return false;
        
            node.Value = value;
            return true;
       
    }
    public bool InsertAt( int index, int value)
    {
        var current = Get(index);
        if( current == null) return false;
        if (index ==0)
        {
            UnShift(value);
        }
        if (index == Length)
        {
            Push(value);
        }
       else
        {
            var newnode = new DoublyNode(value);
            var oldPrevNode = current.Prev;
            newnode.Prev = oldPrevNode;
            newnode.Next = current;
            current.Prev = newnode;
            oldPrevNode.Next = newnode;
           
        }
        Length++;
        return true;
    }
    public bool RemoveAt( int index )
    {
        if (index <0 || index >= Length)
        {
            return false;
      
        }
        if (index ==0)
        {
            Shift();
            return true;
        }
        if (index == Length-1)
        {
            Pop();
            return true;

        }
        var current = Get(index);

        if (current != null)
        {
            current.Prev.Next = current.Next;
            current.Next.Prev = current.Prev;
            current.Next = null;
            current.Prev = null;
            Length--;
            return true;
        }

        return false;



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
