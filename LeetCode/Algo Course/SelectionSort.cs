using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algo_Course
{
    internal class SelectionSort
    {
        // selection sort -> time complexity O(n^2)
        public static int[] SortedArr(int[] arr)
        {

            //[5,3,4,1,2]
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                int index=0;
                for (int j = i+1; j < arr.Length; j++)
                {
                   
                    if (temp > arr[j])
                    {
                        temp = arr[j];
                        index= j;
                    }
                    if (j==arr.Length -1)
                    {
                        int temp2 = arr[i];
                        arr[i] = arr[index];
                        arr[index] = temp2;
                    }
                }

               

            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            return arr;
        }
        public static int[] SortedArrV2(int[] arr)
        {

            //[5,3,4,1,2]
            for (int i = 0; i < arr.Length; i++)
            {
              
                int index = i;
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[index] > arr[j])
                        index = j;
                }

                int temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;


            }
            foreach (var item in arr)
                  Console.WriteLine(item);
            
            return arr;
        }
    }
}
