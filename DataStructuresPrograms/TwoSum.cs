using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace DataStructuresPrograms
{
    class TwoSum
    {
        public int[] TwoSum1(int[] nums, int target)
        {

            if (nums.Length == 0)
            {
                return nums;
            }

            var returnResult = new int[2];

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsValue(nums[i]))
                {
                    int result = dic.Keys.FirstOrDefault(s => dic[s] == nums[i]);
                    returnResult[0] = result;
                    returnResult[1] = i;

                    return returnResult;
                }
                else
                {
                    dic.Add(i, target - nums[i]);
                }
            }

            return returnResult;
        }
    }
}
