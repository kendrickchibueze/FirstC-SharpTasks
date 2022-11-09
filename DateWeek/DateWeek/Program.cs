using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
             PrintColorMessage(ConsoleColor.Yellow,"*****Welcome To My Date App*****");
             GetAppInfo();
             getNewDate();
             Console.ReadLine();
        }


   
        static void getNewDate()
        {
            Console.WriteLine("Enter a date in this example format 11/8/2022 : " );
            DateTime userDateTime;
            if (DateTime.TryParse(Console.ReadLine(), out userDateTime))
            {
                PrintColorMessage(ConsoleColor.Yellow,"The day of your inputed date is : " + userDateTime.DayOfWeek);
                PrintColorMessage(ConsoleColor.Yellow, "The date of the  next one week is: " + userDateTime.Date.AddDays(7).ToString("d/MM/yy"));
                
                
            }
            else
            {
                   PrintColorMessage(ConsoleColor.Red, "You have entered an incorrect date Format.");
            }
           
        }

          //Get and display app Info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Date of Next One Week ";
            string appVersion = "1.0.0";
            string appAuthor = "kendrck";

            //Change text color
            Console.ForegroundColor = ConsoleColor.DarkGreen;


            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //reset text color
            Console.ResetColor();
        }

       

         static void PrintColorMessage(ConsoleColor color, string message)
        {
            //tell user it is not a valid year
            Console.ForegroundColor = color;

            //tell user its not a number
            Console.WriteLine(message);

            //reset text color
            Console.ResetColor();
        }
    }
}
