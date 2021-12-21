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
        public static void UserInput()
        {
            
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
        }
        string msg = "";
        public string regex_firstName = "^[A-Z]{1}[a-z]{2,}$";
        public string regex_lastName = "^[A-Z]{1}[a-z]{2,}$";
        public string regex_email = "^[a-z0-9]+(.[a-z0-9]+)?@[a-z]+[.][a-z]{2,3}(.[a-z]{2})?$";
        public string regex_mobileNumber = "^[1-9][0-9]{1,2}[ ][0-9]{10}$";
        public string regex_password = "^(?=.*[A-Z])(?=.*[0-9])(?=.*?[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8,}$";
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
        public string ValidateLastName(string lastName)
        {
            try
            {
                if (lastName.Equals(""))
                {
                    throw new RegistrationCustomExceptions(RegistrationCustomExceptions.ExceptionType.NOT_NULL, "LastName Should not be null");
                }
                if (Regex.IsMatch(lastName, regex_lastName).Equals(true))
                {
                    msg = "validation successfull";
                }
                else
                {
                    throw new RegistrationCustomExceptions(RegistrationCustomExceptions.ExceptionType.INVALID_FIRSTNAME, "LastName Should Starts with caps and and have minimum three characters"); ;
                }
            }
            catch (RegistrationCustomExceptions ex)
            {
                Console.WriteLine("Exception : "+ex.Message);
            }
            return msg;
        }
        public string ValidateEmail(string email)
        {
            try
            {
                if (email.Equals(""))
                {
                    throw new RegistrationCustomExceptions(RegistrationCustomExceptions.ExceptionType.NOT_NULL, "Email Should not be null");
                }
                if (Regex.IsMatch(email, regex_email).Equals(true))
                {
                    msg = "validation successfull";
                }
                else
                {
                    throw new RegistrationCustomExceptions(RegistrationCustomExceptions.ExceptionType.INVALID_FIRSTNAME, "Email is Invalid"); ;
                }
            }
            catch (RegistrationCustomExceptions ex)
            {
                Console.WriteLine("Exception : "+ex.Message);
            }
            return msg;
        }
        public string ValidateMobileNumber(string mobile)
        {
            try
            {
                if (mobile.Equals(""))
                {
                    throw new RegistrationCustomExceptions(RegistrationCustomExceptions.ExceptionType.NOT_NULL, "Mobile number Should not be null");
                }
                if (Regex.IsMatch(mobile, regex_mobileNumber).Equals(true))
                {
                    msg = "validation successfull";
                }
                else
                {
                    throw new RegistrationCustomExceptions(RegistrationCustomExceptions.ExceptionType.INVALID_FIRSTNAME, "Mobile number should start with country code and have space between code and 10 digit mobile number"); ;
                }
            }
            catch (RegistrationCustomExceptions ex)
            {
                Console.WriteLine("Exception : "+ex.Message);
            }
            return msg;
        }
        public string ValidatePassword(string password)
        {
            try
            {
                if (password.Equals(""))
                {
                    throw new RegistrationCustomExceptions(RegistrationCustomExceptions.ExceptionType.NOT_NULL, "Password Should not be null");
                }
                if (Regex.IsMatch(password, regex_password).Equals(true))
                {
                    msg = "validation successfull";
                }
                else
                {
                    throw new RegistrationCustomExceptions(RegistrationCustomExceptions.ExceptionType.INVALID_FIRSTNAME, "Rule1 : Minimum 8 characters\nRule2 : Sould have atleast 1 capital letter\nRule3 : Should have atleast 1 numeric number\nRule4 : Should have exact 1 special character ");
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

