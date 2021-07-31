using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise01
{
    class Program
    {
        // Program to check user regex against user input
        // A default regex that checks for at least one digit is used if no regex provided
        // User can terminate by pressing ESC

        // default regex
        private static String defaultRegex = "\\d{1}";
        private static Regex regex;

        static void Main(string[] args)
        {
            Console.WriteLine("The default regular expression checks for at least one digit");

            // ESC control flag
            Boolean isEscape = false;

            while (!isEscape)
            {
                String userRegex = readRegex();
                String input = readInput();

                regex = new Regex(userRegex, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                Boolean result = regex.Matches(input).Count > 0;
                Console.WriteLine("{0} matches {1} {2}", input, userRegex, result);

                Console.Write("Press ESC to end or any key to try again. ");

                // update control flag
                isEscape = Console.ReadKey().Key == ConsoleKey.Escape;
                Console.WriteLine("\n\n");
               
            }

        }

        private static String readRegex()
        {
            Console.Write("Enter a regular expression (or press ENTER to use the default): ");
            String userRegex = Console.ReadLine();
            return userRegex.Length == 0? defaultRegex : userRegex;
        }

        private static String readInput()
        {
            Console.Write("Enter some input: ");
            String input = Console.ReadLine();
            return input;
        }

    }
}
