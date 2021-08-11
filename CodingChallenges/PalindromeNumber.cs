using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    class PalindromeNumber
    {
        public bool IsPalindrome (int x)
        {
            Stack<char> s = new Stack<char>();
            string value_to_check = x.ToString();
            int string_lenght = value_to_check.Length;
            
           for(int i = 0; i< value_to_check.Length; i++)
            {
                if(!value_to_check[i].Equals(value_to_check[string_lenght-1]))
                {
                    return false;
                }
                string_lenght--;
            }

            return true;
        }
    }
}
