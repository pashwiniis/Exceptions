using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegestartionRegex;

namespace UserRegestrationRegex
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User registration using Regex");
            RegestrationRegexPattern registrationPattern = new RegestrationRegexPattern();
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine(registrationPattern.ValidateFirstName(firstName));
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine(registrationPattern.ValidateFirstName(lastName));
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine(registrationPattern.ValidateEmail(email));
            Console.WriteLine("Enter Mobile Number");
            string mobile = Console.ReadLine();
            Console.WriteLine(registrationPattern.ValidateMobileNumber(mobile));
            Console.WriteLine("Create Password");
            string password = Console.ReadLine();
            Console.WriteLine(registrationPattern.ValidatePassword(password));
            Console.ReadKey();
        }
    }
}
