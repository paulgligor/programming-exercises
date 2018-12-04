using System;
using Solution.Service;
using Xunit;

namespace Solution.Tests
{
    public class FrogJmpTests
    {
        [Fact]
        public void Solution_SmallNumbers_Correct()
        {
            //Arrange - Given
            var currentPosition = 10;
            var futurePosition = 80;
            var oneStepLength = 30;

            //Act - When
            var result = FrogJmp.Solution(currentPosition, futurePosition, oneStepLength);

            //Assert - Then
            var expectedResult = 3;
            Assert.Equal(expectedResult, result);
        }
    }
}
