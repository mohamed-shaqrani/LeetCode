using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
internal class ThreeSumFun
{
    //[-1,0,1,2,-1,-4]
    //[-4-1-1,0,1,2]

    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var list = nums.OrderBy(x => x).ToList();
        bool flag = false;
        var res = new List<List<int>>();
        var getZeroIndex = list.IndexOf(0);
        for (var i = getZeroIndex; i >  0; i--)
        {
            var first  = list[i];
            var second = list[i+1];

            if (list[i]== list[i+1])
            {
                res.Add(new List<int> { list[i] });
                res.Add(new List<int> { list[i+1] });
                res.Add(new List<int> { 0 });
                flag = true;

            }
            continue;

            for (var j = getZeroIndex; j < list.Count - 1; j++)
            {

            }

                Console.WriteLine(list[i]);
        }
        return (IList<IList<int>>)nums.OrderBy(x => x).ToList();
    }
}
