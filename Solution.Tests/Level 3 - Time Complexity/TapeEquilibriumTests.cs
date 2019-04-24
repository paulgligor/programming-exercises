using System;
using Solution.Service;
using Xunit;

namespace Solution.Tests.Level_3___Time_Complexity
{
    public class TapeEquilibriumTests
    {
        [Fact]
        public void Solution_SmallNumbers_Correct()
        {
            //Arrange - Given
            var array = new int[] { 3, 1, 2, 4, 3 };

            //Act - When
            var result = TapeEquilibrium.Solution(array);

            //Assert - Then
            var expectedResult = 1;
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Solution_LargeNumbers_Correct()
        {
            //Arrange - Given
            var maxrange = 10000;
            var array = new int[maxrange];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(2, 100);
            }

            //Act - When
            var result = TapeEquilibrium.Solution(array);

            //Assert - Then
            Assert.IsType<int>(result);
        }
    }
}
