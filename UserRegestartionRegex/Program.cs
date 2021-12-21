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
        }
    }
}
