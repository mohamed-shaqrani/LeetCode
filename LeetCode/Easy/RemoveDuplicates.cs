using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class RemoveDuplicates
    {
        //[0, 0, 1, 1, 1, 2, 2, 3, 3, 4]
        public static int RemoveDuplicatesInt(int[] nums)
        {
            int k = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[k++] = nums[i];
                }
            }
            return k;


        }
        public static int RemoveElement(int[] nums,int val)
        {
            //Input: nums = [3,2,2,3], val = 3
            //Output: 2, nums = [2,2,_,_]
            //[0,1,2,2,3,0,4,2] 2
            if (nums.Length <=0 )
            {
                return 0;
            }
           
            int k = 1;
            int track = 0;
            int right =  nums.Length-1;
            for (int i = 0; i < nums.Length; i++)
            {
               
                
                if (track + k  == nums.Length - 1)
                {
                    break;
                }
                if (nums[i] != val)
                {
                    k++;
                    continue;

                }
                if (nums[i] == val && nums[i] == nums[right] )
                {
                    while (nums[i] == val && nums[i] == nums[right])
                    {
                        right--;
                        track++;
                    }
                    int temp = nums[right];
                    nums[right] = nums[i];
                    nums[i] = temp;
                    right--;
                    track ++;
                    continue;
                }
                if (nums[i] == val && nums[i] != nums[right])
                {
                    int temp = nums[right];
                    nums[right] = nums[i];
                    nums[i] = temp;
                    right--;
                    track ++;
                    continue;
                }
            }
            
            Array.Resize(ref nums, k+1);
            return k+1;





        }
    }
}
