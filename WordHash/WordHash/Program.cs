using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintColorMessage(ConsoleColor.Cyan,"*****Welcome To My Hash App****");
            GetAppInfo();
            FunWithStrings();
            Console.ReadLine();

        }

        static void FunWithStrings()
        {

            PrintColorMessage(ConsoleColor.Yellow,"Pleaase enter the word");
            string word = Console.ReadLine();
            int index = 4;


            if (word.Length > index)
            {
                string lastwords = word.Substring(word.Length - index);
                int lastwordsIndex = word.IndexOf(lastwords);
                string newString = word.Remove(lastwordsIndex, lastwords.Length);
                //Console.WriteLine(newString);
                string hashedWords = "";
                foreach (char c in newString)
                {
                    if (c == ' ')
                        hashedWords += "#";
                    else
                        hashedWords += "#";

                }
                string resultingWords = hashedWords + lastwords;
                Console.WriteLine(resultingWords);
            }
            else
                 PrintColorMessage(ConsoleColor.Red,"The input string should be more than 4");
            Console.ReadLine();


        }
           //Get and display app Info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Word Hash App ";
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
