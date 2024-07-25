// See https://aka.ms/new-console-template for more information
using LeetCode;
using LeetCode.Algo_Course;
using LeetCode.DS;
using LeetCode.DS.DoublyLinkedList;
using LeetCode.Easy;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World!");

//LargestPerimeter.LargestPerimeterV2([1, 2, 1, 10]);
//var doubleLinkedList = new DoublyLinkedList();
//doubleLinkedList.Push(1);
//doubleLinkedList.Push(2);
//doubleLinkedList.Push(3);

//doubleLinkedList.Push(4);
//doubleLinkedList.Push(5);
//doubleLinkedList.Push(6);

//doubleLinkedList.Set(6,100);
//var queue = new CustomQueue();
//queue.Enueue(10);
////queue.Enueue(20);
////queue.Enueue(30);
////queue.Enueue(40);
//queue.Dequeue();
//queue.Dequeue();
//queue.Dequeue();
var product  = new Product();
//product.CollectOddValues([1, 2, 3, 4, 5]);
var sorted = MergeAlgo.MergSort([1, 10, 50,2, 14, 99,100]);//queue.PrintList();
foreach (var item in sorted)
{
    Console.WriteLine(item);
}
