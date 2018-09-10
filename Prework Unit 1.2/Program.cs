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

            bool tempLoop = true;
            TimeSpan difference;

            while (temp)
            {
                Console.WriteLine("Please enter the first date\n");
                string userDate1 = Console.ReadLine();

                if(testDate == false)
                    tempLoop = 
            }

            Console.WriteLine("Please enter the first date\n");
            string userDate2 = Console.ReadLine();

            //Console.WriteLine("Enter the Month ");
            string dateString = "02/30/2008";

            //DateTime date1 = DateTime.Parse(dateString,
                         //             System.Globalization.CultureInfo.InvariantCulture);
            //Console.WriteLine(date1);

            // Define two dates. year, month, day, military hour, min, sec
            DateTime date2 = new DateTime(2010, 1, 1, 8, 0, 15);
            DateTime date3 = new DateTime(2010, 8, 18, 13, 30, 30);

            // Calculate the interval between the two dates without negitive numbers.
            if (date3 >= date2)
            {
                difference = date3 - date2;
            }
            else
            {
                difference = date2 - date3;
            }
            //test for the timespan answer
            //Console.WriteLine("{0} - {1} = {2}", date2, date3, difference.ToString());


            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", "The difference is: ",
                 difference.Days, "days,", difference.Hours, "hours and", difference.Minutes, 
                 "mins");

            Console.ReadLine();
        }

        public static bool testDate (string inputDateTogther)
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
