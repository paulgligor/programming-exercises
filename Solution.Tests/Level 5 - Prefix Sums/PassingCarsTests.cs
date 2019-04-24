using Solution.Service.Level_5___Prefix_Sums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Solution.Tests.Level_5___Prefix_Sums
{
    public class PassingCarsTests
    {
        [Fact]
        public void Solution_SmallArray_Correct()
        {
            //Arrange - Given
            var array = new int[] { 0, 1, 0, 1, 1 };

            //Act - When
            var result = PassingCars.Solution(array);

            //Assert - Then
            var expectedResult = 5;
            Assert.Equal(expectedResult, result);
        }
    }
}
