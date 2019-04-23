using Solution.Service.Level_6___Sorting;
using Xunit;

namespace Solution.Tests
{
    public class DistinctTests
    {
        [Fact]
        public void Solution_SmallArray_Correct()
        {
            //Arrange - Given
            var array = new int[] { 2, 1, 1, 2, 3, 1 };

            //Act - When
            var result = Distinct.Solution(array);

            //Assert - Then
            var expectedResult = 3;
            Assert.Equal(expectedResult, result);
        }
    }
}
