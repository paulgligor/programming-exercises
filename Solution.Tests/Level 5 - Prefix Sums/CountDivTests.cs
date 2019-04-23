using Solution.Service.Level_5___Prefix_Sums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Solution.Tests.Level_5___Prefix_Sums
{
    public class CountDivTests
    {
        [Fact]
        public void Solution_SmallNumbers_Correct()
        {
            //Arrange - Given
            var startNumer = 5;
            var endNumber = 11;
            var dividedBy = 2;

            //Act - When
            var result = CountDiv.Solution(startNumer, endNumber, dividedBy);

            //Assert - Then
            var expectedResult = 3;
            Assert.Equal(expectedResult, result);

        }
    }
}
