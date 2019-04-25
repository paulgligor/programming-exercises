using Solution.Service.Level_6___Sorting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Solution.Tests.Level_6___Sorting
{
    public class TriangleTests
    {
        [Fact]
        public void Solution_SmallArray_Correct()
        {
            //Arrange - Given
            var array = new int[] { 10, 2, 5, 1, 8, 20 };

            //Act - When
            var result = Triangle.Solution(array);

            //Assert - Then
            var expectedResult = 1;
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Solution_NoTriangles_Correct()
        {
            //Arrange - Given
            var array = new int[] { 10, 50, 5, 1 };

            //Act - When
            var result = Triangle.Solution(array);

            //Assert - Then
            var expectedResult = 0;
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Solution_OneElement_Correct()
        {
            //Arrange - Given
            var array = new int[] { 1 };

            //Act - When
            var result = Triangle.Solution(array);

            //Assert - Then
            var expectedResult = 0;
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Solution_TwoElement_Correct()
        {
            //Arrange - Given
            var array = new int[] { 1, 10 };

            //Act - When
            var result = Triangle.Solution(array);

            //Assert - Then
            var expectedResult = 0;
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Solution_Empty_Correct()
        {
            //Arrange - Given
            int[] array = new int[0];

            //Act - When
            var result = Triangle.Solution(array);

            //Assert - Then
            var expectedResult = 0;
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Solution_Duplicates_Correct()
        {
            //Arrange - Given
            int[] array = new int[] { 1, 1, 1, 1, 5, 5, 5 };

            //Act - When
            var result = Triangle.Solution(array);

            //Assert - Then
            var expectedResult = 1;
            Assert.Equal(expectedResult, result);
        }

        
    }
}
