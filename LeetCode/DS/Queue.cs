using LinList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DS
{
    internal class CustomQueue
    {
        public Node First {  get; set; }
        public Node Last { get; set; }
        public int Length { get; set; }
        public void Enueue(int val )
        {
            var newNode  = new  Node(val);
            if (Length == 0)
            {
                First = newNode;
                Last = newNode;
                
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }
            Length++;
        }
        public void Dequeue()
        {
            if (Length == 0)
            {
               return;

            }
            if (First == Last)
            {
                First = null;
                Last = null;
                return;
            }
            else
            {
                First = First.Next;
            }
            Length--;
        }
        public void PrintList()
        {
            var head = First;
            if (Length > 0)
            {
                while (head != null)
                {
                    Console.WriteLine(head.Value);
                    head = head.Next;
                }

            }
        }
    }
}
