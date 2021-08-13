using System;

namespace CodingChallenges
{
    class ChallengeRunner
    {
        static void Main(string[] args)
        {
            ValidParenthesesChallenge par = new ValidParenthesesChallenge();
            Console.WriteLine("Expected TRUE, solution was: " + par.IsValid("()"));
            Console.WriteLine("Expected TRUE, solution was: " + par.IsValid("()[]{}"));
            Console.WriteLine("Expected FALSE, solution was: " + par.IsValid("(]"));
            Console.WriteLine("Expected FALSE, solution was: " + par.IsValid("([)]"));
            Console.WriteLine("Expected TRUE, solution was: " + par.IsValid("{[]}"));
            Console.WriteLine("Expected FALSE, solution was: " + par.IsValid("){"));
            Console.WriteLine("Expected FALSE, solution was: " + par.IsValid("]()"));

        }        
      
    }
}
