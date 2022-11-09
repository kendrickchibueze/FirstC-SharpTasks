using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgt
{
    internal class Program
    {
        static void Main(string[] args)
        {
             PrintColorMessage(ConsoleColor.Cyan, "****Welcome To the TalentLibrary ****");
             Console.WriteLine();
             GetAppInfo();
             Console.WriteLine();
             CheckAvailableBooks();
             Console.ReadLine();
        }


        static void CheckAvailableBooks()
        {
           
                
                Console.Write("c [C# Books], o [.NET Core Books], d[clean coding Books], e[EFCore Books]");
                PrintColorMessage(ConsoleColor.Blue,"\nPlease kindly select your preferred Books : ");
                char BookChoice = Console.ReadLine()[0];
                

                switch (BookChoice) 
                {
                    case 'c':
                         
                        PrintColorMessage(ConsoleColor.Yellow, "Good choice!,  Our C# book is a good one to read");
                        break;
                    case 'o':
                        PrintColorMessage(ConsoleColor.Yellow, " Namzy's .NET Core Books is here for you!, happy reading!");
                        break;
                    case 'd':
                    PrintColorMessage(ConsoleColor.Yellow,"Alex's Clean Coding book helps you write better codes!");
                        break;
                    case 'e':
                    PrintColorMessage(ConsoleColor.Yellow,"EFCore Books are Available For You");
                        break;
                    default:
                    PrintColorMessage(ConsoleColor.Yellow,"Well, you would have to try again!");
                        break;
                }

            
        }

          //Get and display app Info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Library Management System ";
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
