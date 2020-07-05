using System;
using System.Collections.Generic;

namespace myApp
{
    class TwoSum    
    {        
        public int[] twoSum(int[] nums, int target)
        {
            
            Dictionary<int,int> dict=new Dictionary<int, int>();
            int other =0;
            for (int i = 0; i < nums.Length; i++)
            {
                other=target-nums[i];
                int index=0;
                if (other>0 && dict.TryGetValue(other, out index))
                {
                    return new int[]{index,i};
                }           
                if (dict.ContainsKey(nums[i])==false)
                {
                    dict.Add(nums[i],i);
                }

            }

            return null;

        }
    }
}
