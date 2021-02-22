using System;
using Xunit;

namespace Gradebook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // Arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(73.3);
            book.AddGrade(42.1);

            // Act
            var result = book.GetStatistics();

            // Assert
            Assert.Equal(68.2, result.Average, 1);
            Assert.Equal(89.1, result.High, 1);
            Assert.Equal(42.1, result.Low, 1);
        }
    }
}
