using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Task: Write a C# console application to calculate the duration between two dates in Years,
Months and Days. The user should enter two dates as input, then the program will show the
result of the difference in time between these two dates. Show the difference in days, hours, and
minutes.
To complete this task, you’ll need to use what you’ve learned in addition to some research. 
*/
namespace Prework_Unit_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Program will calculate the difference between two dates\n");

            string userDate1 = "0", userDate2 = "0";
            bool tempLoop = true;
            TimeSpan difference;

            while (tempLoop)
            {
                Console.WriteLine("Please enter the first date in format '1/11/2011' : ");
                userDate1 = Console.ReadLine();

                if (TestDate(userDate1) == true)
                    tempLoop = false;
            }

            tempLoop = true;
            while (tempLoop)
            {
                Console.WriteLine("Please enter the second in format '1/11/2011' :");
                userDate2 = Console.ReadLine();

                if (TestDate(userDate2) == true)
                    tempLoop = false;
            }


            //DateTime date1 = DateTime.Parse(dateString,
            //             System.Globalization.CultureInfo.InvariantCulture);
            //Console.WriteLine(date1);

            // Define two dates. year, month, day, military hour, min, sec
            DateTime date1 = DateTime.Parse(userDate1,
                System.Globalization.CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.Parse(userDate2,
                System.Globalization.CultureInfo.InvariantCulture);

            // Calculate the interval between the two dates without negitive numbers.
            if (date2 >= date1)
            {
                difference = date2 - date1;
            }
            else
            {
                difference = date1 - date2;
            }
            //test for the timespan answer
            //Console.WriteLine("{0} - {1} = {2}", date2, date3, difference.ToString());


            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", "The difference is: ",
                 difference.Days, "days,", difference.Hours, "hours and", difference.Minutes, 
                 "mins \n OR \n" );
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", "The difference is: ",
                difference.TotalDays, "Total days. OR", difference.TotalHours, "Total hours. OR", 
                difference.TotalMinutes,"Total mins.");

            Console.ReadLine();
        }

        public static bool TestDate (string inputDateTogther)
        {
            DateTime tempDate;
            if (DateTime.TryParse(inputDateTogther, out tempDate))
            {
                Console.WriteLine("Converted '{0}' to {1}.", inputDateTogther,
                                    tempDate);
                return true;
            }
            else
            {
                Console.WriteLine("Try again and enter a vaild date. '{0}' is not a vaild date.\n",
                    inputDateTogther);
                return false;
            }
        }
    }
}
