﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solution.Service.Level_6___Sorting
{
    public class NumberOfDiscIntersections
    {
        /*
        We draw N discs on a plane. The discs are numbered from 0 to N − 1. An array A of N non-negative integers, specifying the radiuses of the discs, is given. The J-th disc is drawn with its center at (J, 0) and radius A[J].

        We say that the J-th disc and K-th disc intersect if J ≠ K and the J-th and K-th discs have at least one common point (assuming that the discs contain their borders).

        The figure below shows discs drawn for N = 6 and A as follows:

            A[0] = 1
            A[1] = 5
            A[2] = 2
            A[3] = 1
            A[4] = 4
            A[5] = 0

        There are eleven (unordered) pairs of discs that intersect, namely:

        discs 1 and 4 intersect, and both intersect with all the other discs;
        disc 2 also intersects with discs 0 and 3.
        Write a function:

        class Solution { public int solution(int[] A); }

        that, given an array A describing N discs as explained above, returns the number of (unordered) pairs of intersecting discs. The function should return −1 if the number of intersecting pairs exceeds 10,000,000.

        Given array A shown above, the function should return 11, as explained above.

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [0..100,000];
        each element of array A is an integer within the range [0..2,147,483,647].
        */

        /// <summary>
        /// 62% Solution
        /// </summary>
        public static int Solution(int[] A)
        {
            var result = 0;
            var pointA = 0;
            var pointB = 0;
            var pointX = 0;
            var pointY = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if(result > 10000000)
                    {
                        return -1;
                    }
                    pointA = i - A[i];
                    pointB = i + A[i];
                    pointX = j - A[j];
                    pointY = j + A[j];

                    if (
                        (pointA <= pointX && pointX <= pointB)
                        ||
                        (pointA <= pointY && pointY <= pointB)
                        ||
                        (pointX <= pointA && pointA <= pointY)
                        ||
                        (pointX <= pointB && pointB <= pointY)
                        )
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
