using LinList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DS.DoublyLinkedList
{
    internal class DoublyNode
    {
        public int Value { get; set; }
        public DoublyNode Next { get; set; }
        public DoublyNode Prev { get; set; }

        public DoublyNode(int val)
        {
            Value = val;
            Next = null;
            Prev = null;
        }

    }
}
