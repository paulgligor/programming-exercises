using System;
using Solution.Service;
using Xunit;
using System.Collections.Generic;

namespace Solution.Tests.Level_3___Time_Complexity
{
    public class PermMissingElemTests
    {
        [Fact]
        public void Solution_SmallNumbers_Correct()
        {
            //Arrange - Given
            var array = new int[] { 2, 3, 1, 5 };

            //Act - When
            var result = PermMissingElem.Solution(array);

            //Assert - Then
            var expectedResult = 4;
            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void Solution_LargeNumbers_Correct()
        {
            //Arrange - Given
            var maxrange = 10000;
            var array = new int[maxrange];
            for (int i = 0; i < maxrange; i++)
            {
                array[i] = i + 1;
            }
            Random rnd = new Random();

            var listHere = new List<int>(array);
            int selectedIndex = rnd.Next(1, maxrange);
            listHere.RemoveAt(selectedIndex);
            array = listHere.ToArray();

            //Act - When
            var result = PermMissingElem.Solution(array);

            //Assert - Then
            var expectedResult = selectedIndex + 1;
            Assert.Equal(expectedResult, result);

        }
    }
}
