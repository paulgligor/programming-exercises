using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Service.Level_7___Stacks_and_Queues
{
    public class Brackets
    {
        /*
        A string S consisting of N characters is considered to be properly nested if any of the following conditions is true:

        S is empty;
        S has the form "(U)" or "[U]" or "{U}" where U is a properly nested string;
        S has the form "VW" where V and W are properly nested strings.
        For example, the string "{[()()]}" is properly nested but "([)()]" is not.

        Write a function:

        class Solution { public int solution(string S); }

        that, given a string S consisting of N characters, returns 1 if S is properly nested and 0 otherwise.

        For example, given S = "{[()()]}", the function should return 1 and given S = "([)()]", the function should return 0, as explained above.

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [0..200,000];
        string S consists only of the following characters: "(", "{", "[", "]", "}" and/or ")".
        */

        private static char[] openBracketsArray = new char[] { '(', '{', '[' };
        private static char[] closeBracketsArray = new char[] { ')', '}', ']' };
        
        /// <summary>
        /// Solution
        /// </summary>
        public static int Solution(string S)
        {
            var nextState = "";
            for (int i = 0; i < S.Length; i++)
            {
                if (isOpen(S[i]))
                {
                    nextState = getNextState(S[i]) + nextState;
                }
                else if (isClosed(S[i]))
                {
                    if (string.IsNullOrEmpty(nextState))
                    {
                        return 0;
                    }
                    else
                    {
                        if (S[i] == nextState[0])
                        {
                            nextState = nextState.Remove(0, 1);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(nextState))
                return 0;

            return 1;
        }

        private static bool isOpen(char s)
        {
            for (int i = 0; i < openBracketsArray.Length; i++)
            {
                if (openBracketsArray[i] == s)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool isClosed(char s)
        {
            for (int i = 0; i < closeBracketsArray.Length; i++)
            {
                if (closeBracketsArray[i] == s)
                {
                    return true;
                }
            }

            return false;
        }

        private static string getNextState(char s)
        {
            for (int i = 0; i < openBracketsArray.Length; i++)
            {
                if (openBracketsArray[i] == s)
                {
                    return closeBracketsArray[i].ToString();
                }
            }

            return string.Empty;
        }
    }
}
