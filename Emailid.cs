using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexProgram
{
    public  class Emailid
    {
        public static string Regex_Email = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        public  bool validateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }

        public static void checkemail(string email)
        {
            if (Regex.IsMatch(email, Regex_Email) == false)
            {
                Console.WriteLine("Enter valid email address!");
            }
            else
            {
                Console.WriteLine("Email is correct");
            }
        }
    }
}