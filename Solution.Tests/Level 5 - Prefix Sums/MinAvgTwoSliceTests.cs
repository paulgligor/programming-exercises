using Solution.Service.Level_5___Prefix_Sums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Solution.Tests.Level_5___Prefix_Sums
{
    public class MinAvgTwoSliceTests
    {
        [Fact]
        public void Solution_SmallArray_Correct()
        {
            //Arrange - Given
            var array = new int[] { 4, 2, 2, 5, 1, 5, 8 };

            //Act - When
            var result = MinAvgTwoSlice.Solution(array);

            //Assert - Then
            var expectedResult = 1;
            Assert.Equal(expectedResult, result);

        }
    }
}
