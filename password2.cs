using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexProgram
{
    public  class password2
    {

        public static string Regex_Password = "^((?=.*[A-Z])(?=.{8,}))";

        public static bool validatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }

        public static void checkPassword2(string password)
        {
            if (Regex.IsMatch(password, Regex_Password) == false)
            {
                Console.WriteLine("Enter valid password. It should contain minimum 8 character," +
                    "atleast one upper case character");
            }
            else
            {
                Console.WriteLine("password is accepted");
            }
        }
    }
}
