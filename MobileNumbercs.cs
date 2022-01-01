using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexProgram
{
    public  class MobileNumbercs
    {
        public static string Regex_Number = "^[1-9]{2}[ ][6-9][0-9]{9}$";
        public static bool validatenumber(string number)
        {
            return Regex.IsMatch(number, Regex_Number);
        }

        public static void checknumber(string number)
        {
            if (Regex.IsMatch(number, Regex_Number) == false)
            {
                Console.WriteLine("Enter valid Mobile Number!");
            }
            else
            {
                Console.WriteLine("entered number is accepted");
            }
        }
    }
}
