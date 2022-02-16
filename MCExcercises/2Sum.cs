using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCExcercises
{
    public class _2Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> prevMap = new Dictionary<int, int>();
            
            for (int i=0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (prevMap.ContainsValue(diff))
                    return new int[] { prevMap.FirstOrDefault(x => x.Value == diff).Key, i };
                else
                    prevMap.Add(i, nums[i]);
            }

            return Array.Empty<int>();
        }
    }
}
