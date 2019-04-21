using Solution.Service.Level_5___Prefix_Sums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Solution.Tests.Level_5___Prefix_Sums
{
    public class GenomicRangeQueryTests
    {
        [Fact]
        public void Solution_SmallArray_Correct()
        {
            //Arrange - Given
            var stringDNA = "CAGCCTA";
            var pQueries = new int[] { 2, 5, 0 };
            var qQueries = new int[] { 4, 5, 6 };

            //Act - When
            var result = GenomicRangeQuery.Solution(stringDNA, pQueries, qQueries);

            //Assert - Then
            var expectedResult = new int[] { 2, 4, 1 };
            Assert.Equal(expectedResult, result);
        }
    }
}
