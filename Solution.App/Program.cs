using System;
using System.Collections.Generic;

using Solution.Service;

namespace Solution.App
{
    class Program
    {
        #region Properties

        

        #endregion

        static void Main(string[] args)
        {
            //RunPermCheck();
            RunFrogRiverOne();

            Console.Read();
        }

        #region Leve 1 - Iterations



        #endregion

        #region Level 4 Counting Elements

        private static void RunPermCheck()
        {
            Console.WriteLine($" --------- 4.1 PermCheck --------- ");

            var result = PermCheck.Solution(new int[] { 4, 3, 1, 2});
            Console.WriteLine($"result = {result}");
        }

        private static void RunFrogRiverOne()
        {
            Console.WriteLine($" --------- 4.2 FrogRiverOne --------- ");

            var result = FrogRiverOne.Solution(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 });
            Console.WriteLine($"result = {result}");
            var result2 = FrogRiverOne.Solution(2, new int[] { 2, 2, 2 });
            Console.WriteLine($"result = {result2}");
            var result3 = FrogRiverOne.Solution(1, new int[] { 1 });
            Console.WriteLine($"result = {result3}");
        }

        #endregion
    }
}
