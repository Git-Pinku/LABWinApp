using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace UserApp
{
    class Program
    {
       static string username;
       static string password;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("******************************************************");
            Console.WriteLine("|-------------------LMS User Setting-----------------|");
            Console.WriteLine("******************************************************");
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
           // Console.Write("Please Enter Username: ");
            //username = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Please Enter Password: ");
           // password = ReadPassword();


            bool confirmed = false;
            do
            {
                Console.Write("Please Enter Username:");
                username = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Please Enter Password: ");
                password = ReadPassword();

                ConsoleKey response;
                do
                {
                    Console.WriteLine();
                    Console.Write("Are you sure you want to change Username and Password? [y/n] ");
                    response = Console.ReadKey(false).Key;   // true is intercept key (dont show), false is show
                    if (response != ConsoleKey.Enter)
                        Console.WriteLine();

                } while (response != ConsoleKey.Y && response != ConsoleKey.N);

                confirmed = response == ConsoleKey.Y;
            } while (!confirmed);
            //Update here user name and password..
            if (!(string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password)))
            {
                //DataTable dt = clsdb.GetReports();
                
                if (clsdb.UpdateUserPassword(username.Trim(), password.Trim()))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Username and Password updated successfully!!");
                }
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    
                    Console.WriteLine("Error::  Unable to Update Username and Password !!");
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
  

        }


        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        // remove one character from the list of password characters
                        password = password.Substring(0, password.Length - 1);
                        // get the location of the cursor
                        int pos = Console.CursorLeft;
                        // move the cursor to the left by one character
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        // replace it with space
                        Console.Write(" ");
                        // move the cursor to the left by one character again
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }
            Console.WriteLine();
            return password;

        }


    }
}
