using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateProject
{
    class DateCreator
    {

        private Date someDate;

        public void RunProgram()
        {
            int dayNumber = 31;
            int monthNumber = 12;
            int yearNumber = 1999;

            bool theYearIsALeapYear;

            someDate = new Date(dayNumber, monthNumber, yearNumber);

            theYearIsALeapYear = someDate.isLeapYear();

            if (theYearIsALeapYear)
            {
                Console.WriteLine($"The Year {someDate.Year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"The Year {someDate.Year} is not a leap year.");
            }

            Console.WriteLine("\n***************************************************************\n");

            int totalDays;

            totalDays = someDate.NumberOfDays();

            Console.WriteLine($"Total days from 1/1 to {someDate.Day}/{someDate.Month} is {totalDays} days.");

            Console.WriteLine("\n***************************************************************\n");

            string dayName;

            dayName = someDate.DayOfWeek();

            Console.WriteLine($"The Date of {someDate.Day}/{someDate.Month}/{someDate.Year} was a {dayName}");
        }


        static void Main(string[] args)
        {

            DateCreator myDateCreator = new DateCreator();
            myDateCreator.RunProgram();


            Console.WriteLine("\n\n===============================");
            Console.WriteLine("DateCreator: Press any key to finish");
            Console.ReadKey();
        }
    }
}
