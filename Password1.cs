using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexProgram
{
    public  class Password1
    {
        public static string Regex_Password = "^[A-Za-z]{8,}";
            public static bool validatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }

        public static void checkPassword(string password)
        {
            if (Regex.IsMatch(password, Regex_Password) == false)
            {
                Console.WriteLine("Enter valid password. It should contain minimum 8 character!");
            }
            else
            {
                Console.WriteLine("password accepted ");
            }
        }

    }
}
