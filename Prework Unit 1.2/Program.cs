using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prework_Unit_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Program will calculate the difference between two dates\n");
            //Initalizing the string values and the loop value.
            string userDate1 = "0", userDate2 = "0";
            bool tempLoop = true;
            //adding or subtracting a date time makes a timespan number/class initializing container
            TimeSpan difference;

            //while loop will be true until the user inputs a correct date that is tested by
            //the TestDate method. Once the TestDate is true it will return to false.
            while (tempLoop)
            {
                Console.WriteLine("Please enter the first date in format '1/11/2011' : ");
                userDate1 = Console.ReadLine();

                if (TestDate(userDate1) == true)
                    tempLoop = false;
            }

            //setting temp loop back to true
            //while loop will be true until the user inputs a correct date that is tested by
            //the TestDate method. Once the TestDate is true it will return the loop to false.
            tempLoop = true;
            while (tempLoop)
            {
                Console.WriteLine("Please enter the second in format '1/11/2011' :");
                userDate2 = Console.ReadLine();

                if (TestDate(userDate2) == true)
                    tempLoop = false;
            }
            /*
            testing out msdn formats for parse
            DateTime date1 = DateTime.Parse(dateString,
                        System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(date1);
            */

            // Assigns the string values of the user inputs to DateTime using certain format.
            //Parse is done because Testparse has already been completed from TestDate method.
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

            //This out puts the differance Timespan object into days hours and minutes.
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", "The difference is: ",
                 difference.Days, "days,", difference.Hours, "hours and", difference.Minutes, 
                 "mins \n\n OR \n" );
            //This outputs the differance Timespan object into Total days Total hours and Total
            //mins
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", "The difference is: ",
                difference.TotalDays, "Total days. OR", difference.TotalHours, "Total hours. OR", 
                difference.TotalMinutes,"Total mins.");
            Console.WriteLine("\n Press 'Enter' to end the program.");
            Console.ReadLine();
        }

        //This method grabs the user input from each loop and does a tryparse to see if it is 
        // a valid date. If the date is valid it will return true if false it gives the user
        // and error and returns false.
        public static bool TestDate (string inputDateTogther)
        {
            DateTime tempDate;
            if (DateTime.TryParse(inputDateTogther, out tempDate))
            {
                //Test. Grabs the string value and shows the parse value if true.
                //Console.WriteLine("Converted '{0}' to {1}.", inputDateTogther,
                //                    tempDate);
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
