using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum.Solution
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {

            for (int x = 0; x < nums.Length; x++)
            {
                int remain = target - nums[x];

                for (int y = x + 1; y < nums.Length; y++)
                {
                    if (nums[y] == remain)
                    {
                        return new int[] { x, y };
                    }
                }
            }

            throw new Exception("numbers in array doesn't match with target");
        }
    }
}
