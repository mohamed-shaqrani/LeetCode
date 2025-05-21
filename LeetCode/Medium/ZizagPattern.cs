using System.Text;

namespace LeetCode.Medium;
internal class ZizagPattern
{

    public string Convert(string s, int numRows)
    {
        int tracker = 0;
        //Input: s = "PAYPALISHIRING", numRows = 4
        //Output: "PINALSIGYAHRPI"
        Dictionary<int, List<char>> dic = new Dictionary<int, List<char>>();

        if (s.Length == 1)
        {
            return s;
        }

        while (tracker < s.Length)
        {

            for (int i = 0; i < numRows; i++)
            {
                var key = i + 1;

                if (dic.ContainsKey(key))
                {
                    dic[key].Add(s[tracker]);
                }
                else
                {
                    dic.Add(key, new List<char> { s[tracker] });

                }
                tracker++;
                if (tracker == s.Length)
                {
                    break;

                }
                if (i + 1 == numRows)
                {
                    var numBackRows = numRows - 2;
                    var startKey = dic.Keys.Last() - 1;
                    while (numBackRows > 0 && tracker < s.Length)
                    {
                        var test = s[tracker];
                        dic[startKey].Add(s[tracker]);
                        tracker = tracker + 1;
                        numBackRows--;
                        startKey--;
                    }

                }
            }

        }
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var kvp in dic.OrderBy(k => k.Key))
        {
            List<char> values = kvp.Value;
            foreach (char c in values)
            {
                stringBuilder.Append(c);
            }
        }

        Console.WriteLine("Result: " + stringBuilder.ToString());  // 👉 Output: PINALSIGYAHRPI
        return stringBuilder.ToString();
    }

}
