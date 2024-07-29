// See https://aka.ms/new-console-template for more information
using LeetCode;
using LeetCode.Algo_Course;
using LeetCode.DS;
using LeetCode.DS.BinarySearchTree;
using LeetCode.DS.DoublyLinkedList;
using LeetCode.Easy;
using LeetCode.Medium;
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
//product.CollectOddValues([1, 2, 3, 4, 5]);

//Console.WriteLine(Anagram.IsAnagram("ac", "bb")); 
Console.WriteLine(Anagram.IsAnagramV5("aacc", "ccac"));
Console.WriteLine(Anagram.IsAnagramV5("ac", "bb"));
var two = new TwoSum();
int[] nums = [3, 2, 4]; int target = 6;
 two.FindTwoSum(nums, target);
var res = nums.Select((n, i) => new { number = n, index = i });
foreach(var item in res)
{
    Console.WriteLine($"number:{item.number} ,Index {item.index}" );
}
GrouptAnagramMed.GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]);

