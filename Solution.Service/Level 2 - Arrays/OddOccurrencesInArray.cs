using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Service
{
    public class OddOccurrencesInArray
    {
        /*
         
            A non-empty array A consisting of N integers is given. The array contains an odd number of elements, and each element of the array can be paired with another element that has the same value, except for one element that is left unpaired.
            For example, in array A such that:
              A[0] = 9  A[1] = 3  A[2] = 9
              A[3] = 3  A[4] = 9  A[5] = 7
              A[6] = 9
            the elements at indexes 0 and 2 have value 9,
            the elements at indexes 1 and 3 have value 3,
            the elements at indexes 4 and 6 have value 9,
            the element at index 5 has value 7 and is unpaired.
            Write a function:
                class Solution { public int solution(int[] A); }
            that, given an array A consisting of N integers fulfilling the above conditions, returns the value of the unpaired element.
            For example, given array A such that:
              A[0] = 9  A[1] = 3  A[2] = 9
              A[3] = 3  A[4] = 9  A[5] = 7
              A[6] = 9
            the function should return 7, as explained in the example above.
            Write an efficient algorithm for the following assumptions:
            N is an odd integer within the range [1..1,000,000];
            each element of array A is an integer within the range [1..1,000,000,000];
            all but one of the values in A occur an even number of times.

         */

        /// <summary>
        /// 66% Solution
        /// </summary>
        /// <param name="A">Int array</param>
        /// <returns>Returns the value of the unpaired element</returns>
        public static int Solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A != null && A.Length != 0)
            {
                var iterate = A.ToList();
                var list = A.ToList();
                foreach (var item in iterate)
                {
                    list.Remove(item);
                    if (list.Count() == 1)
                    {
                        return list[0];
                    }
                    var found = list.Find(e => e == item);
                    if (found > 0)
                    {
                        list.Remove(found);
                    }
                    else
                    {
                        return item;
                    }
                }
            }

            return -1;
        }
    }
}
