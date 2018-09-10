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
            //Console.WriteLine("This Program will calculate the difference between two dates\n");
            //Console.WriteLine("Please enter the first date\n");
            //Console.WriteLine("Enter the Month ");
            string dateString = "5/1/2008 8:30:52 AM";
            DateTime date1 = DateTime.Parse(dateString,
                                      System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(date1);
            string iso8601String = "20080501T08:30:52Z";
            DateTime dateISO8602 = DateTime.ParseExact(iso8601String, "yyyyMMddTHH:mm:ssZ",
                                            System.Globalization.CultureInfo.InvariantCulture);


            Console.WriteLine(iso8601String);

            // Define two dates.
            DateTime date2 = new DateTime(2010, 1, 1, 8, 0, 15);
            DateTime date3 = new DateTime(2010, 8, 18, 13, 30, 30);
            // Calculate the interval between the two dates.
            TimeSpan interval = date3 - date2;
            Console.WriteLine("{0} - {1} = {2}", date2, date3, interval.ToString());
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", "The difference is: ",
                 interval.Days, "days,", interval.Hours, "hours and", interval.Minutes, "mins");

            Console.ReadLine();
        }

        /*public static date FullDate (int month, int day, int year)
        {
            Console.WriteLine("Enter the Month ");
            month = Convert.ToDateTime(Console.ReadLine();
        }*/
    }
}
