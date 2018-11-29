using System;
using System.Collections.Generic;

using Solution.Service;

namespace Solution.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void RunCyclicRotation()
        {
            Console.WriteLine($" --------- CyclicRotation --------- ");
            var sol = CyclicRotation.Solution(new int[] { 1, 2, 3, 4 }, 2);
            foreach (var item in sol)
            {
                Console.WriteLine($"= {item}");
            }
        }

        // Lever 2 Arrays
        public static void RunOddOccurrencesInArray()
        {
            Console.WriteLine($" --------- OddOccurrencesInArray --------- ");
            var sol = OddOccurrencesInArray.Solution(new int[] { 2, 2, 3, 3, 4 });
            Console.WriteLine($"= {sol}");
        }

        // Level 3 Time Complexity
        public static void RunPermMissingElem()
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
    }
}
