using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    class MyAtoiChallenge
    {
         public int MyAtoi(string s)
        {

            bool is_negative = false;
            int i = 0;
            string result = "";
            if (s.Length == 0)
            {
                return 0;
            }

            char[] charArr = s.ToCharArray();

            if (charArr.Length == 1)
            {
                if (StringHasNumbers(charArr[0]))
                {
                    result = result + charArr[0];
                    return Int32.Parse(result);
                }
                else
                {
                    return 0;
                }
            }
            while (i < charArr.Length)
            {
                if (charArr[i] != ' ')
                {
                    break;
                }
                i++;

            }

            if (i == charArr.Length) return 0;

            if (StringHasNumbers(charArr[i]) && i < charArr.Length)
            {
                result = result + charArr[i];
                i++;
            }
            else if (charArr[i] == '+' && i < charArr.Length)
            {
                result = result + charArr[i];
                i++;
            }
            else if (charArr[i] == '-' && i < charArr.Length)
            {
                is_negative = true;
                result = result + charArr[i];
                i++;
            }
            else
            {
                return 0;
            }

            for (int j = i; j < charArr.Length; j++)
            {
                if (StringHasNumbers(charArr[j]))
                {
                    result = result + charArr[j];
                }
                else
                {
                    break;
                }
            }

            if (result.Equals("-") || result.Equals("+"))
            {
                return 0;
            }

            try
            {
                return Int32.Parse(result);

            }
            catch (Exception e)
            {
                if (is_negative == true)
                {
                    return Int32.MinValue;
                }
                else
                {
                    return Int32.MaxValue;
                }
            }
        }
        private bool StringHasNumbers(char c)
        {
            if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' ||
                c == '7' || c == '8' || c == '9')
            {
                return true;
            }
            return false;
        }
    }
}
