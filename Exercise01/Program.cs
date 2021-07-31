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

        static void Main(string[] args)
        {
            String input = "\\d{1}";
            Regex rx = new Regex(input, RegexOptions.Compiled | RegexOptions.IgnoreCase);

            MatchCollection matches = rx.Matches("helllo15");

            Console.WriteLine("Count "+matches.Count);

            Console.Read();

        }
    }
}
