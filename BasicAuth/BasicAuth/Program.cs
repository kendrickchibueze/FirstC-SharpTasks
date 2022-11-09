using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAuth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintColorMessage(ConsoleColor.Cyan,"****Welcome To Our Authentication System*****");
            UserReg();
            Console.WriteLine();
            UserLogin();
            Console.ReadLine();
        }

        static void UserReg()
        {
            PrintColorMessage(ConsoleColor.Blue, "Welcome!, You would have to signUp");
            string username, password,email,phonenumber = string.Empty;
             
            PrintColorMessage(ConsoleColor.Cyan,"Enter your username:");
            username = Console.ReadLine();
            PrintColorMessage(ConsoleColor.Cyan,"Enter your password:");
            password = Console.ReadLine();
            PrintColorMessage(ConsoleColor.Cyan,"Enter you Email:");
            email = Console.ReadLine();
            PrintColorMessage(ConsoleColor.Cyan,"Enter phone number:");
            phonenumber = Console.ReadLine();
          

            using (StreamWriter sw = new StreamWriter(File.Create(@"C:\\Users\\ENVY\\source\new.txt")))
            {
                sw.WriteLine(username);
                sw.WriteLine(password);
                sw.WriteLine(email);
                sw.WriteLine(phonenumber);
                sw.Close();
            }
            PrintColorMessage(ConsoleColor.Yellow,"Registration successful...");
            Console.WriteLine();
            PrintColorMessage(ConsoleColor.Yellow,"Continue to Login...");
            Console.ReadLine();
        }


        static void UserLogin()
        {
            PrintColorMessage(ConsoleColor.Blue, "Please Login With your details!");
            string username, password, username1,password1 = string.Empty;
            PrintColorMessage(ConsoleColor.Cyan,"Enter your username:");
            username = Console.ReadLine();
            PrintColorMessage(ConsoleColor.Cyan,"Enter your password:");
            password = Console.ReadLine();

            using (StreamReader sr = new StreamReader(File.Open(@"C:\\Users\\ENVY\\source\new.txt", FileMode.Open)))
            {
                username1 = sr.ReadLine();
                password1 = sr.ReadLine();
                sr.Close();
            }

            if(username == username1 && password == password1)
            {
                PrintColorMessage(ConsoleColor.Yellow,"Login Successful!");
            }
            else
            {
                PrintColorMessage(ConsoleColor.Yellow, "Login Failed!");
            }
            Console.ReadLine();

        }

             //Get and display app Info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Basic Authentication System ";
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
