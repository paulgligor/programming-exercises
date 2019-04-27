using Solution.Service.Level_7___Stacks_and_Queues;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Solution.Tests.Level_7___Stacks_and_Queues
{
    public class BracketsTests
    {
        [Fact]
        public void Solution_EmptyString_Correct()
        {
            //Arrange - Given
            var aString = "";

            //Act - When
            var result = Brackets.Solution(aString);

            //Assert - Then
            var expectedResult = 1;
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Solution_SmallString_Correct()
        {
            //Arrange - Given
            var aString = "{[()()]}";

            //Act - When
            var result = Brackets.Solution(aString);

            //Assert - Then
            var expectedResult = 1;
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Solution_SmallString2_Correct()
        {
            //Arrange - Given
            var aString = "(U)";

            //Act - When
            var result = Brackets.Solution(aString);

            //Assert - Then
            var expectedResult = 1;
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Solution_SmallString3_Correct()
        {
            //Arrange - Given
            var aString = "VW";

            //Act - When
            var result = Brackets.Solution(aString);

            //Assert - Then
            var expectedResult = 1;
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Solution_SmallString_Incorrect()
        {
            //Arrange - Given
            var aString = "([)()]";

            //Act - When
            var result = Brackets.Solution(aString);

            //Assert - Then
            var expectedResult = 0;
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Solution_SmallString2_Incorrect()
        {
            //Arrange - Given
            var aString = ")(";

            //Act - When
            var result = Brackets.Solution(aString);

            //Assert - Then
            var expectedResult = 0;
            Assert.Equal(expectedResult, result);
        }

    }
}
