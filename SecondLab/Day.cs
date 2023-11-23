﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
    internal class Day
    {
        private DateTime ddate;
        public Day(DateTime date)
        {
            this.ddate= date;
            
        }

        public string IndexOfDay()
        {
            int result=(int)ddate.DayOfWeek;
                switch (result)
            {
                case 0: return "Sunday";
                case 1: return "Monday";
                case 2: return "Tuesday";
                case 3: return "Wednesday";
                case 4: return "Thursday";
                case 5: return "Friday";
                case 6: return "Saturday";
                default : throw new Exception();
            }
        }
    }
}