using LeetCode.DS.DoublyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.tEST;
internal class SLL
{
    public DoublyNode head;
    public DoublyNode tail;
    public int Length;

    public void Push(int val)
    {
        var newNode = new DoublyNode(val);

        if (head == null)
        {

            head = newNode;
            tail = newNode;
        }
        else
        {

            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
        Length++;


    }
    public void Traverse()
    {
        var current = head;
        while (current != null)
        {
            Console.WriteLine(current.Value);

            current = current.Next;

        }
    }
    public void Pop()
    {

        var current = tail;
        if (current.Prev != null)
        {

            tail = current.Prev;
            tail.Next = null;

        }
        else
        {
            head = null;
            tail = null;
        }
        Length--;

    }
    public void Shift()
    {
        var current = head;
        if (current.Next != null)
        {

            head = current.Next;
            current.Next = null;
            head.Prev = null;
        }
        else
        {
            head = null;
            tail = null;
        }
        Length--;

    }
    public void UnShift(int val)
    {
        var newNode = new DoublyNode(val);
        var currnt  = head;
        if (head == null)
        {
            tail = newNode;
            head = newNode;
        }
        else {
             head.Prev = newNode;
             newNode.Next = currnt;
             head = newNode;
        }
        Length++;

    }
    public int Get (int index)
    {
      var average  =  Math.Ceiling((decimal)Length / 2);
         var curentLen  = Length;
        var current  = head;
        for (int i = 0; i < Length-1; i++)
        {
            current = head.Next;

            if (index == i)
            {
                Console.WriteLine("Get " +current.Next.Value);
                return current.Value;
            }
            curentLen--;

        }
        return 0;
    }

}
