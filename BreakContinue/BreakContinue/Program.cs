using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintColorMessage(ConsoleColor.Cyan,"**** This Differenciates Break and Continue in C# *******");
            BreakExample();
            Console.WriteLine();
            ContinueExample();
            Console.ReadLine();


        }

        static void BreakExample()
        {
            PrintColorMessage(ConsoleColor.Yellow,"For the Break Example Output:");
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 4)
                {
                    break;
                }
            }
        }

        static void ContinueExample()
        {
            PrintColorMessage(ConsoleColor.Yellow, "For the Continue Example Output:");
            int i = 0;
            while (i < 10)
            {
                if (i == 4)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
        }

        //Get and display app Info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Break and Continue Code ";
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
