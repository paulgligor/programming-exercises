using System;
using Solution.Service;
using Xunit;

namespace Solution.Tests
{
    public class CyclicRotationTests
    {
        [Fact]
        public void Solution_SmallNumbers_Corect()
        {
            //Arrange - Given
            var array = new int[] { 1, 2, 3, 4 };
            var rotations = 2;

            //Act - When
            var result = CyclicRotation.Solution(array, rotations);

            //Assert - Then
            var expectedResult = new int[] { 3, 4, 1, 2};
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Solution_SmallNumbers_Incorect()
        {
            //Arrange - Given
            var array = new int[] { 1, 2, 3, 4 };
            var rotations = 3;

            //Act - When
            var result = CyclicRotation.Solution(array, rotations);

            //Assert - Then
            var expectedResult = new int[] { 3, 4, 1, 2 };
            Assert.NotEqual(expectedResult, result);

        }
    }
}
