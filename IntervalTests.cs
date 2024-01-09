using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondLab;
namespace TestProject1
{
    public class IntervalTests
    {
        [Fact]

        public void FindInterval_WhenDate1IsEarlier_ReturnsPositiveValue()
        {
   
            DateTime date1 = new DateTime(2022, 1, 1);
            DateTime date2 = new DateTime(2022, 1, 5);
            Interval interval = new Interval(date1, date2);
            int result = interval.FindInterval();

            Assert.Equal(4, result);
        }


        [Fact]
        public void FindInterval_WhenDate1IsLater_ReturnsNegativeValue()
        {
     
            DateTime date1 = new DateTime(2022, 1, 5);
            DateTime date2 = new DateTime(2022, 1, 1);
            Interval interval = new Interval(date1, date2);

            int result = interval.FindInterval();

            Assert.Equal(-4, result);
        }
        [Fact]
        public void FindInterval_WhenDatesAreEqual_ReturnsZero()
        {
            DateTime date1 = new DateTime(2022, 1, 1);
            DateTime date2 = new DateTime(2022, 1, 1);
            Interval interval = new Interval(date1, date2);

            int result = interval.FindInterval();

            Assert.Equal(0, result);
        }
    }
}

