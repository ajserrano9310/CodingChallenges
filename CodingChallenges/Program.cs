using System;

namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "42";
            string test_2 = "    -42";
            string test_3 = "4193 with words";
            string test_4 = "words and 987"; // -> 0
            string test_5 = "00000-42a1234"; // -> 0
            string test_6 = "+"; // -> 0
            string test_7 = "-"; // -> 0
            string test_8 = "   +0 123"; // -> 0
            string test_9 = "-91283472332"; // -> minValue
            string test_10 = "1"; // -> 1
            string test_11 = " ";
            string test_12 = "-5-";
            string test_13 = "-13+8";

            Console.WriteLine(MyAtoi(s));
            Console.WriteLine("Test 2 " + MyAtoi( test_2));

            Console.WriteLine("Test 3 " + MyAtoi(test_3));

            Console.WriteLine("Test 4 " + MyAtoi(test_4));

            Console.WriteLine("Test 5 " + MyAtoi( test_5));
            Console.WriteLine("Test 6 " + MyAtoi( test_6));
            Console.WriteLine("Test 7 " + MyAtoi( test_7));
            Console.WriteLine("Test 8 " + MyAtoi( test_8));
            Console.WriteLine("Test 9 " + MyAtoi( test_9));
            Console.WriteLine("Test 10 " + MyAtoi( test_10));
            Console.WriteLine("Test 11 " + MyAtoi(test_11));
            Console.WriteLine("Test 12 " + MyAtoi(test_12));
            Console.WriteLine("Test 13 " + MyAtoi(test_13));
        }

        static public int MyAtoi(string s)
        {

            bool is_negative = false;
            int i = 0;
            string result = "";
            if (s.Length == 0)
            {
                return 0;
            }

            char[] charArr = s.ToCharArray();

            if(charArr.Length == 1)
            {
                if(StringHasNumbers(charArr[0]))
                {
                    result = result + charArr[0];
                    return Int32.Parse(result);
                }
                else
                {
                    return 0;
                }
            }
            while(i < charArr.Length)
            {
                if(charArr[i] != ' ')
                {
                    break;
                }
                i++;
                
            }

            if (i == charArr.Length) return 0;

            if(StringHasNumbers(charArr[i]) && i < charArr.Length)
            {
                result = result + charArr[i];
                i++;
            }
            else if(charArr[i] == '+' && i < charArr.Length)
            {
                result = result + charArr[i];
                i++; 
            }
            else if(charArr[i] == '-'&& i < charArr.Length)
            {
                is_negative = true;
                result = result + charArr[i];
                i++;
            }
            else
            {
                return 0;
            }
            
            for(int j = i; j < charArr.Length;  j++)
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

        static private bool StringHasNumbers(char c)
        {
            if(c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' ||
                c == '7' || c == '8'||c=='9')
            {
                return true;
            }
            return false;
        }
    }
}
