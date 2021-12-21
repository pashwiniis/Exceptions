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
            
            ReflectionOnUserRegestration.ReflectionTest();
            RegestrationRegexPattern.UserInput();
            Console.ReadKey();
        }
    }
}
