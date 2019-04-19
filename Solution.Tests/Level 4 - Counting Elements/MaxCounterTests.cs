using Solution.Service.Level_4___Counting_Elements;
using System;
using Xunit;

namespace Solution.Tests
{
    public class MaxCounterTests
    {
        [Fact]
        public void Solution_SmallNumbers_Correct()
        {
            //Arrange - Given
            var counters = 5;
            var array = new int[] { 3, 4, 4, 6, 1, 4, 4 };

            //Act - When
            var result = MaxCounters.Solution(counters, array);

            //Assert - Then
            var expectedResult = new int[] { 3, 2, 2, 4, 2 };
            Assert.Equal(expectedResult, result);
        }

    }
}
