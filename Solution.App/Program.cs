using System;
using System.Collections.Generic;

using Solution.Service;

namespace Solution.App
{
    class Program
    {
        static void Main(string[] args)
        {
            RunCyclicRotation();
            RunOddOccurrencesInArray();
            RunPermMissingElem();

            Console.Read();
        }

        #region Leve 1 - Iterations



        #endregion

        #region Level 2 - Arrays

        private static void RunCyclicRotation()
        {
            Console.WriteLine($" --------- CyclicRotation --------- ");
            var sol = CyclicRotation.Solution(new int[] { 1, 2, 3, 4 }, 2);
            foreach (var item in sol)
            {
                Console.WriteLine($"= {item}");
            }
        }

        private static void RunOddOccurrencesInArray()
        {
            Console.WriteLine($" --------- OddOccurrencesInArray --------- ");
            var sol = OddOccurrencesInArray.Solution(new int[] { 2, 2, 3, 3, 4 });
            Console.WriteLine($"= {sol}");
        }

        #endregion

        #region Level 3 - Time Complexity

        private static void RunPermMissingElem()
        {
            Console.WriteLine($" --------- PermMissingElem --------- ");
            var maxrange = 1000000;
            var arrayHere = new int[maxrange];
            for (int i = 0; i < maxrange; i++)
            {
                arrayHere[i] = i + 1;
            }
            Random rnd = new Random();
            int number = rnd.Next(1, maxrange);
            var listHere = new List<int>(arrayHere);
            listHere.RemoveAt(number);
            arrayHere = listHere.ToArray();

            var sol3 = PermMissingElem.Solution(arrayHere);
            Console.WriteLine($"= {sol3}");
        }

        #endregion
    }
}
