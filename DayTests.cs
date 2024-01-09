using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondLab;
namespace TestProject1
{
    public class DayTests
    {
        [Fact]

        public void IndexOfDay_ReturnsSunday()
        {
            DateTime date = new DateTime(2022, 10, 23);
            Day DayTest = new Day(date);
            string result = DayTest.IndexOfDay();
            Assert.Equal("Sunday", result);
        }

        [Fact]
        public void IndexOfDay_ReturnsMonday()
        {
            // Arrange
            DateTime date = new DateTime(2022, 10, 24);
            Day DayTest = new Day(date);

            // Act
            string result = DayTest.IndexOfDay();

            // Assert
            Assert.Equal("Monday", result);
        }
    }
}
