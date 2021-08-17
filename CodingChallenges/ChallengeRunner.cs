using System;

namespace CodingChallenges
{
    class ChallengeRunner
    {
        static void Main(string[] args)
        {
            RemoveElementChallenge remove = new RemoveElementChallenge();
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;
            remove.RemoveElement(nums, val);
            int[] nums2 = { 0, 1, 2, 2, 3, 0, 4, 2 }; int val2 = 2;
            remove.RemoveElement(nums2, val2);
        }        
      
    }
}
