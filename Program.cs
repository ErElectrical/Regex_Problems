using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegexProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to regex Programs ");
            Console.WriteLine("validate your First name ");
            Patterns pat = new Patterns();
            pat.Pattern();

            Console.WriteLine("validate your last name ");
           
            Console.WriteLine("enter your last name ");
        

            string l_name =Console.ReadLine();
            Lastname ls = new Lastname();

            ls.checkLastName(l_name);

            Console.Write("Enter your email addresss: ");
            string email = Console.ReadLine();
            Emailid.checkemail(email);

            Console.Write("Enter your Mobile number : ");
            string Phone = Console.ReadLine();
            MobileNumbercs.checknumber(Phone);


            Console.Write("Enter your password: ");
           string password = Console.ReadLine();
            Password1.checkPassword(password);

        }
    }
}