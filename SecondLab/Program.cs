using static System.Net.Mime.MediaTypeNames;

namespace SecondLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("Use one of commands:");
            Console.WriteLine("'check' to check is year leap");
            Console.WriteLine("'calc' to calc interval lenght");
            Console.WriteLine("'day' to get the name of day of week");
            Console.WriteLine("'quit' to exit");
            Console.WriteLine("----");

            string command;
            do
            {
                Console.WriteLine("Input the command:");
                command = Console.ReadLine();

                if (command == "check")
                {
                    Console.WriteLine("Input the year:");
                    int year = int.Parse(Console.ReadLine());

                    Year yea = new Year(year);
                    if (yea.isLeapYear())
                    {
                        Console.WriteLine("Is year " + year + " leap?" + "True");
                    }
                    else
                    {
                        Console.WriteLine("Is year" + year + "leap?" + "False");
                    }
                }

                else if (command == "calc")
                {
                    Console.WriteLine("Input the year1:");
                    int year1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input the month1:");
                    int month1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input the day1:");
                    int day1 = int.Parse(Console.ReadLine());
                    DateTime date1 = new DateTime(year1, month1, day1);
                    Console.WriteLine(date1);

                    Console.WriteLine("Input the year2:");
                    int year2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input the month2:");
                    int month2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input the day2:");
                    int day2 = int.Parse(Console.ReadLine());
                    DateTime date2 = new DateTime(year2, month2, day2);
                    Console.WriteLine(date2);

                    Interval interval = new Interval(date1, date2);
                    Console.WriteLine("interval lenght between " + date1 + " and " + date2 + " " + interval.FindInterval());

                }

                else if (command == "day")
                {
                    Console.WriteLine("Input the year:");
                    int year = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input the month:");
                    int month = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input the day:");
                    int day = int.Parse(Console.ReadLine());

                    DateTime date = new DateTime(year, month, day);
                    Day nameday = new Day(date);
                    Console.WriteLine(date);
                    Console.WriteLine(nameday.IndexOfDay());
                }

                else if (command == "quit")
                {
                    break;
                }
                else
                {
                    throw new Exception("False");
                }
            
            }
    
            while (command != "quit");
            
            }
            }
            
    }
    