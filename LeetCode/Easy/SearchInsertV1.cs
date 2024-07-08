
namespace LeetCode.Easy;

internal static class SearchInsert
{
    public static int SearchInsertV1(int[] nums, int target)
    {
        int before = 0;
        int after = 0; ;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                return target;
            }
            if (nums.Length - 1 == i && after == 0)
            {
                if (nums[i] > target)
                {
                    return i;
                }
                return i + 1;
            }
            if (nums[i] < target)
            {
                before = nums[i];
                continue;
            }
            if (nums[i] > target)
            {
                after = nums[i];
            }

            if (after != 0 && before != 0)
            {
                return i;
            }



        }
        return 0;
    }
}

