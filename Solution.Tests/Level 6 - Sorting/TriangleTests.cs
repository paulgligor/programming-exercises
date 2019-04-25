using Solution.Service.Level_6___Sorting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Solution.Tests.Level_6___Sorting
{
    public class TriangleTests
    {
        [Fact]
        public void Solution_SmallArray_Correct()
        {
            //Arrange - Given
            var array = new int[] { 10, 2, 5, 1, 8, 20 };

            //Act - When
            var result = Triangle.Solution(array);

            //Assert - Then
            var expectedResult = 1;
            Assert.Equal(expectedResult, result);
        }
    }
}
