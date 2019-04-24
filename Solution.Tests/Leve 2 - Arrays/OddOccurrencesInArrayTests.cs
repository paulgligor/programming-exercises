using System;
using Solution.Service;
using Xunit;

namespace Solution.Tests.Leve_2___Arrays
{
    public class OddOccurrencesInArrayTests
    {
        [Fact]
        public void Solution_SmallNumbers_Correct()
        {
            //Arrange - Given
            var array = new int[] { 2, 3, 4, 2, 3 };

            //Act - When
            var result = OddOccurrencesInArray.Solution(array);

            //Assert - Then
            var expectedResult = 4;
            Assert.Equal(expectedResult, result);

        }
    }
}
