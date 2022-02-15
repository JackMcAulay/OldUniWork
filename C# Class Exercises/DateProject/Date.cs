using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateProject
{
    class Date
    {
        private int day;
        private int month;
        private int year;

        public Date()
        {
            day = 1;
            month = 1;
            year = 1;
        }

        public Date(int Day, int Month, int Year)
        {
            day = Day;
            month = Month;
            year = Year;
        }

        public bool isLeapYear()
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else if ((year % 4 == 0) && !(year % 100 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int NumberOfDays()
        {
            int numberOfDays = 0;
            for (int i = 1; i <= month; i++)
            {
                if (i == month)
                {
                    numberOfDays += day;
                }
                else if (i == 2)
                {
                    bool isLeapYearThisYear = false;

                    isLeapYearThisYear = isLeapYear();

                    if (isLeapYearThisYear)
                    {
                        numberOfDays += 29;
                    }
                    else
                    {
                        numberOfDays += 28;
                    }
                }
                else if (i == 4 || i == 6 || i == 9 || i == 11)
                {
                    numberOfDays += 30;
                }
                else
                {
                    numberOfDays += 31;
                }

                Console.WriteLine(numberOfDays);
            }

            return numberOfDays;
        }

        public string DayOfWeek()
        {
            string dayOfWeek;
            int h, q, m, k, j;

            q = day;
            m = DayOfWeekMonth();
            k = DayOfTheWeekYearOfCentry();
            j = (year - (year % 100)) / 100;

            h = (q + (13 * (m + 1) / 5) + k + (k / 4) + (j / 4) + (5 * j)) % 7;

            dayOfWeek = DayNumberToDay(7);

            return dayOfWeek;
        }

        private int DayOfWeekMonth()
        {
            if (month > 2)
            {
                return month;
            }
            else
            {
                if (month == 1)
                {
                    return 13;
                }
                else
                {
                    return 14;
                }
            }
        }

        private int DayOfTheWeekYearOfCentry()
        {
            int yearOfCentry = year;

            while (year > 100)
            {
                if (yearOfCentry > 1000)
                {
                    yearOfCentry -= 1000;
                }
                else
                {
                    yearOfCentry -= 100;
                }
            }

            if (month == 1 || month == 2)
            {
                yearOfCentry--;
            }

            return yearOfCentry;
        }

        private string DayNumberToDay(int dayNumber)
        {
            string day = "none";

            if (dayNumber == 1)
            {
                day = "Monday";
            }
            else if (dayNumber == 2)
            {
                day = "Tuesday";
            }
            else if (dayNumber == 3)
            {
                day = "Wednesday";
            }
            else if (dayNumber == 4)
            {
                day = "Thursday";
            }
            else if (dayNumber == 5)
            {
                day = "Friday";
            }
            else if (dayNumber == 6)
            {
                day = "Saturday";
            }
            else if (dayNumber == 7)
            {
                day = "Sunday";
            }

            return day;
        }

        public int Day
        {
            set
            {
                if (value > 0 && value < 32)
                {
                    day = value;
                }
            }

            get { return day; }
        }

        public int Month
        {
            set
            {
                if (value > 0 && value < 13)
                {
                    month = value;
                }
            }

            get { return month; }
        }

        public int Year
        {
            set
            {
                if (value > 0)
                {
                    year = value;
                }
            }

            get { return year; }
        }
    }
}
