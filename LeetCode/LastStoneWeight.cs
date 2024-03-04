namespace LeetCode;
public class LastStoneWeight
{
    public int track = 0;
    public static int GetLastStoneWeight(int[] stones)
    {
       

        if (stones.Length ==1)
        
            return stones[0];
        
        if (stones.Length ==2)
        {
            if (stones[0] < stones[1])
            {
                return stones[1] - stones[0];
            }
            return stones[0] - stones[1];
        }

        var stone = stones.OrderByDescending(x=>x).ToArray();
        HashSet<int> hashSet = new HashSet<int>(stone);//[4,6,4,10]

        while (stone.Length > 2 )
        {
            int sum = stone[0] - stone[1];
            stone[0] = sum;
            int temp = stone[^1];

            stone[1] = temp;
            int[] newArr = new int[stone.Length - 1];
            Array.Copy(stone, 0, newArr, 0, newArr.Length);

            stone = newArr.OrderByDescending(x => x).ToArray(); ;
           

        }
        return stone[0] - stone[1];
    }
}
