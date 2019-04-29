using Solution.Service.Level_7___Stacks_and_Queues;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Solution.Tests.Level_7___Stacks_and_Queues
{
    public class FishTests
    {
        [Fact]
        public void Solution_SmallString3_Correct()
        {
            //Arrange - Given
            var A = new int[] { 4, 3, 2, 1, 5 };
            var B = new int[] { 0, 1, 0, 0, 0 };
            
            //Act - When
            var result = Fish.Solution(A, B);

            //Assert - Then
            var expectedResult = -1;
            Assert.Equal(expectedResult, result);
        }
    }
}
