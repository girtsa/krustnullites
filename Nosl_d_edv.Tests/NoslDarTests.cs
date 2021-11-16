using System;
using Xunit;

namespace NoslDar.Tests
{


    /// <summary>
    /// Ja skaitlis ir 10-14 , tad atgriez "A bit out of array"
    /// Ja skaitlis ir lielāks par 14 , tad atgriez "Far out of array"
    /// 
    ///
    /// </summary>
    public class InputTests
    {
        // Function_When_Then

        [Fact]
        public void GetNumber_WhenInArray_ThenReturnsOK()
        {
            // Arrange
            var isitOK = new NoslDar.Board.Moves();

            // Act
            var maybe = isitOK.GetNumber(9);

            // Assert
            Assert.Equal("OK", maybe);
        }

        [Theory]
        [InlineData(99)]
        

     

        public void GetNumber_WhenOutsideArray_ThenReturnsOutOfArray(int testableNumber)
        {
            // Arrange
            var isitOK = new NoslDar.Board.Moves();

            // Act
            var maybe = isitOK.GetNumber(testableNumber);

            // Assert
            Assert.Equal("OutOfArray", maybe);
        }
    }
}
