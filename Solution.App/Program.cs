using System;
using System.Collections.Generic;

using Solution.Service;

namespace Solution.App
{
    class Program
    {
        #region Properties

        private static int maxrange = 10000;

        #endregion

        static void Main(string[] args)
        {
            //RunCyclicRotation();
            //RunOddOccurrencesInArray();
            //RunPermMissingElem();
            //RunFrogJmp();
            //RunTapeEquilibrium();

            RunPermCheck();

            Console.Read();
        }

        #region Leve 1 - Iterations



        #endregion

        #region Level 2 - Arrays

        private static void RunCyclicRotation()
        {
            Console.WriteLine($" --------- 2.1 CyclicRotation --------- ");
            var sol = CyclicRotation.Solution(new int[] { 1, 2, 3, 4 }, 2);
            foreach (var item in sol)
            {
                Console.WriteLine($"result = {item}");
            }
        }

        private static void RunOddOccurrencesInArray()
        {
            Console.WriteLine($" --------- 2.2 OddOccurrencesInArray --------- ");
            var sol = OddOccurrencesInArray.Solution(new int[] { 2, 2, 3, 3, 4 });
            Console.WriteLine($"result = {sol}");
        }

        #endregion

        #region Level 3 - Time Complexity

        private static void RunFrogJmp()
        {
            Console.WriteLine($" --------- 3.1 FrogJmp --------- ");
            var currentPosition = 10;
            var futurePosition = 80;
            var oneStepLength = 30;
            var result = FrogJmp.Solution(currentPosition, futurePosition, oneStepLength);
            Console.WriteLine($"result = {result}");
        }

        private static void RunPermMissingElem()
        {
            Console.WriteLine($" --------- 3.2 PermMissingElem --------- ");
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

            var result = PermMissingElem.Solution(arrayHere);
            Console.WriteLine($"result = {result}");
        }

        private static void RunTapeEquilibrium()
        {
            Console.WriteLine($" --------- 3.3 TapeEquilibrium --------- ");

            //var arrayHere = new int[] { 3, 1, 2, 4, 3 };

            var arrayHere = new int[maxrange];
            Random rnd = new Random();
            for (int i = 0; i < arrayHere.Length; i++)
            {
                arrayHere[i] = rnd.Next(2, 100);
            }

            var result = TapeEquilibrium.Solution(arrayHere);
            Console.WriteLine($"result = {result}");
        }

        #endregion

        #region Level 4 Counting Elements

        private static void RunPermCheck()
        {
            Console.WriteLine($" --------- 4.1 PermCheck --------- ");

            var result = PermCheck.Solution(new int[] { 4, 3, 1, 2});
            Console.WriteLine($"result = {result}");
        }

        #endregion
    }
}
