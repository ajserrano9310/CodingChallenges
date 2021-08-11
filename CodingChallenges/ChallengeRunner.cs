using System;

namespace CodingChallenges
{
    class ChallengeRunner
    {
        static void Main(string[] args)
        {
            PalindromeNumber number = new PalindromeNumber();
            Console.WriteLine(number.IsPalindrome(2));
            Console.WriteLine(number.IsPalindrome(121));
            Console.WriteLine(number.IsPalindrome(123));
            Console.WriteLine(number.IsPalindrome(-121));
            Console.WriteLine(number.IsPalindrome(-10));
            Console.WriteLine(number.IsPalindrome(-101));

        }        
      
    }
}
