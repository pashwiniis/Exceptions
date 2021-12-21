using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegestartionRegex
{
    public class RegestrationRegexPattern
    {
        string msg = "";
        public string regex_firstName = "^[A-Z]{1}[a-z]{2,}$";
        public string ValidateFirstName(string firstName)
        {
            try
            {
                if (firstName.Equals(""))
                {
                    throw new RegistrationCustomExceptions(RegistrationCustomExceptions.ExceptionType.NOT_NULL, "FirstName Should not be null");
                }
                if (Regex.IsMatch(firstName, regex_firstName).Equals(true))
                {
                    msg = "validation successfull";
                }
                else
                {
                    throw new RegistrationCustomExceptions(RegistrationCustomExceptions.ExceptionType.INVALID_FIRSTNAME, "FirstName Should Starts with caps and and have minimum three characters"); ;
                }
            }
            catch (RegistrationCustomExceptions ex)
            {
                Console.WriteLine("Exception : "+ex.Message);
            }

            return msg;
        }
    }
}
