using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProgram
{
    public class Lastname
    {
       
        public static string Regex_LastName = "^[A-Z][a-z]{2,}$";

        


        public  bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);
        }

        public  void checkLastName(string LastName)
        {
            if (Regex.IsMatch(LastName, Regex_LastName) == false)
            {
                Console.WriteLine("Enter valid Last name. It should Start with capital letters and minimum 3 letters!");
            }
            else
            {
                Console.WriteLine("user last name correct");
            }
        }
    }

}