using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
    internal class Year
    {
        private int yyear;
        public Year(int year)
        {
         this.yyear = year;
        }
        public bool isLeapYear()
        {

            return yyear % 4 == 0 && (yyear % 100 != 0 || yyear % 400 == 0);
        }
    }
}