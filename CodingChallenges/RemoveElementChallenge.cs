using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    class RemoveElementChallenge
    {

        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            int index = 0;
            //int nonval = 0; 

            if (nums.Length == 0) return 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != val)
                {
                    k++;
                }
                else
                {
                    nums[i] = -1;
                    //nonval++;
                }
            }
            int[] arr = new int[k];
            for(int j = 0; j < nums.Length; j ++)
            {
                if (nums[j] == -1) continue;
                else
                {
                    arr[index] = nums[j];
                    index++;
                }
            }
            for(int g = 0; g < nums.Length; g++)
            {
                if (g < arr.Length) nums[g] = arr[g];
                else nums[g] = -1;
            }
            //PrintArray(nums, k, nonval);
            return k;
        }

        public void PrintArray(int[] nums, int k, int nonval)
        {
            string s = "[";
            for(int j = 0; j < nums.Length; j++)
            {
                s = s + nums[j] + ",";
            }

            s = s + "]" + " k = " + k;

            Console.WriteLine(s);
        }
    }
}
