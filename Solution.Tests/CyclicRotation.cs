using Solution.Service;
using System;
using Xunit;

namespace Solution.Tests
{
    public class CyclicRotation
    {
        [Fact]
        public void Cyclic_SmallNumbers_Corect()
        {
            //Arrange - Given
            var array = new int[] { 1, 2, 3, 4 };
            var rotations = 2;

            //Act - When
            var result = Service.CyclicRotation.Solution(array, rotations);

            //Assert - Then
            var expectedResult = new int[] { 3, 4, 1, 2};
            Assert.Equal(expectedResult, result);
        }
    }
}
