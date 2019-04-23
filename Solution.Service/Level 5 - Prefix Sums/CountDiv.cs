using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Service.Level_5___Prefix_Sums
{
    public class CountDiv
    {
        /*
            Write a function:
            class Solution { public int solution(int A, int B, int K); }
            that, given three integers A, B and K, returns the number of integers within the range [A..B] that are divisible by K, i.e.:
            { i : A ≤ i ≤ B, i mod K = 0 }
            For example, for A = 6, B = 11 and K = 2, your function should return 3, because there are three numbers divisible by 2 within the range [6..11], namely 6, 8 and 10.
            Write an efficient algorithm for the following assumptions:
            A and B are integers within the range [0..2,000,000,000];
            K is an integer within the range [1..2,000,000,000];
            A ≤ B.
        */

        /// <summary>
        /// 50% Solution
        /// </summary>
        public static int Solution(int A, int B, int K)
        {
            var result = 0;

            for (int i = A; i <= B; i++)
            {
                if (i % K == 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
