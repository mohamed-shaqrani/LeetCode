// See https://aka.ms/new-console-template for more information
using LeetCode;
using LeetCode.Algo_Course;
using LeetCode.DS.DoublyLinkedList;
using LeetCode.Easy;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World!");

//LargestPerimeter.LargestPerimeterV2([1, 2, 1, 10]);
var doubleLinkedList = new DoublyLinkedList();
doubleLinkedList.Push(1);
doubleLinkedList.Push(2);
doubleLinkedList.Push(3);

doubleLinkedList.Push(4);
doubleLinkedList.Push(5);
doubleLinkedList.Push(6);

//doubleLinkedList.Set(6,100);
doubleLinkedList.RemoveAt(2);
doubleLinkedList.PrintList();

