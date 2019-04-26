using Solution.Service.Level_6___Sorting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Solution.Tests.Level_6___Sorting
{
    public class NumberOfDiscIntersectionsTests
    {
        [Fact]
        public void Solution_SmallArray_Correct()
        {
            //Arrange - Given
            var array = new int[] { 1, 5, 2, 1, 4, 0 };

            //Act - When
            var result = NumberOfDiscIntersections.Solution(array);

            //Assert - Then
            var expectedResult = 11;
            Assert.Equal(expectedResult, result);
        }
    }
}
