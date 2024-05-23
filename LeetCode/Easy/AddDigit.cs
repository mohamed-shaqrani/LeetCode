namespace LeetCode.Easy;

internal class AddDigit
{
    public int AddDigits(int num)
    {
        if (num < 10)
        {
            return num;
        }
        var test = num;
        var sum = num;
        var hitTheEnd = num.ToString().Length;
        int x = 0;//38
        while (sum >= 10)
        {

            x += test % 10;
            test /= 10;
            hitTheEnd--;
            if (hitTheEnd == 0 && x >= 10)
            {
                sum = x;
                test = x;
                x = 0;

                hitTheEnd = sum.ToString().Length;
                continue;
            }
            if (hitTheEnd == 0 && x < 10)
                sum = x;
        }
        return sum;
    }
}