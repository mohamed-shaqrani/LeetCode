using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium;
internal class Rotate
{
    public  static void RotateArr(int[][] matrix)
    {
        //Input: matrix = [[5, 1, 9, 11], [2, 4, 8, 10], [13, 3, 6, 7], [15, 14, 12, 16]]
        //    Output:     [[15, 13, 2, 5],[14, 3, 4, 1], [12, 6, 8, 9], [16, 7, 10, 11]]
        //[15, 14, 12, 16]][13, 3, 6, 7][14, 3, 4, 1]
        //}
        int temp = matrix[0].Length;
        var val = Math.Floor(((decimal) matrix.Length / 2));
        int f =0;
        for (int i =matrix.Length -1; i >0 && i > val-1; i--)
        {
              var swap = matrix[i];
              matrix[i] = matrix[f];
              matrix[f] = swap;
              f++;
        }
        var check = Math.Floor((decimal)(matrix[0].Length / 2) -1) <1?1: Math.Floor((decimal)(matrix[0].Length / 2) - 1);
        var temp1 = 1;
        var arrTracker = 1;
        bool increaseTracker =false;
        var tempNext = 0;
        var x = 0;
        //[[1, 2, 3],[4, 5, 6],[7, 8, 9]]
        //[[7,4,1],[8,5,2],[9,6,3]]
        for (int i = temp1 >x? temp1 : x; i < matrix.Length; i++)
        {
           
           var swap = matrix[i][tempNext];
            if (tempNext == check && check == arrTracker)
            {
                arrTracker++;
                matrix[i][tempNext] = matrix[tempNext][arrTracker];
                matrix[tempNext][arrTracker] = swap;
                arrTracker++;
                increaseTracker =true;

            }
            else {
                matrix[i][tempNext] = matrix[tempNext][arrTracker];
                matrix[tempNext][arrTracker ] = swap;
                arrTracker++;

            }
            if (i==matrix.Length-1)
            {
               tempNext++;
                x++;
                i = x;
                arrTracker =x;
                if (increaseTracker)
                {
                    arrTracker++;
                }

            }


        }
        

    }
}
