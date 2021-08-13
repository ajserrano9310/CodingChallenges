using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    class ValidParenthesesChallenge
    {

        public bool IsValid(string s)
        {
            if (s.Length == 0) return false;
            if (s.Length == 1) return false;
            if (s.Length % 2 != 0) return false;

            Stack<char> check_Par = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{') check_Par.Push(c);

                if(c == ')' || c == ']' || c == '}')
                {
                    if (c == ')')
                    {
                        if ((check_Par.Count!=0) && check_Par.Peek() == '(')
                        {
                            check_Par.Pop();
                        }
                        else return false;
                    }
                    else if ((check_Par.Count != 0) && c == ']')
                    {
                        if (check_Par.Peek() == '[')
                        {
                            check_Par.Pop();
                        }
                        else return false;
                    }
                    else if ((check_Par.Count != 0) && c == '}')
                    {
                        if (check_Par.Peek() == '{')
                        {
                            check_Par.Pop();
                        }
                        else return false;
                    }
                }                
            }

            if (check_Par.Count == 0) return true;

            return false;
        }
    }
}
