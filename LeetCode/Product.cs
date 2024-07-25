using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Product
    {
        public decimal Price {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image {  get; set; }
        public int Total =0;
        public int  Factorial(int num)//4
        {

            if (num ==0) return 1;
                return num * Factorial(num - 1);
            //24
            //4 * 6;
            //     3 * 2;
            //         2 * 1;
        }
        public List<int> CollectOddValues(int[] arr)
        {
            var oddlist  = new List<int>();
            Helper(arr,0, oddlist);
            return oddlist;
        }
        public List<int> Helper(int[] arr,int index, List<int> oddlist)
        {
            if (arr.Length == index) return oddlist;
            if (arr[index] % 2 != 0 )
                 oddlist.Add(arr[index]);

             Helper(arr ,index+1, oddlist);
            return oddlist;
        }
        public static implicit operator Child(Product parent)
        {
            return new Child
            {
                Price = parent.Price,
                Name = parent.Name,
            };
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
