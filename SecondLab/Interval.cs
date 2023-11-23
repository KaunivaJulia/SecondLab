using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
    internal class Interval
    {
        
        private DateTime ddate1;
        private DateTime ddate2;

        public Interval(DateTime date1, DateTime date2)
        {
            
            this.ddate2 = date2;
            this.ddate1 = date1;

        }

        public int FindInterval()
        {
            return (ddate2 - ddate1).Days;
        }
    }
}
