using SecondLab;
namespace TestProject1
{

    public class YearTest
    {
        [Fact]

        public void IsLeapYearReturnsTrue()
        {

            int year = 2020;
            var Year = new Year(year);
            bool result = Year.IsLeapYear(year);
            Assert.True(result);
        }

        [Fact]
        public void IsLeapYearReturnsFalse()
        {
            int year = 2100;
            var Year = new Year(year);
            bool result = Year.IsLeapYear(year);
            Assert.False(result);
        }

    }
}