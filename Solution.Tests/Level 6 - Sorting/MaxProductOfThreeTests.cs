using Solution.Service.Level_6___Sorting;
using Xunit;

namespace Solution.Tests.Level_6___Sorting
{
    public class MaxProductOfThreeTests
    {
        [Fact]
        public void Solution_SmallArray_Correct()
        {
            //Arrange - Given
            var array = new int[] { -3, 1, 2, -2, 5, 6 };

            //Act - When
            var result = MaxProductOfThree.Solution(array);

            //Assert - Then
            var expectedResult = 60;
            Assert.Equal(expectedResult, result);
        }
    }
}
