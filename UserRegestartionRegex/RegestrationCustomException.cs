using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegestartionRegex
{
    public class RegistrationCustomExceptions : Exception
    {
        public enum ExceptionType
        {
            NOT_NULL,
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_EMAIL,
            INVALID_MOBILENUMBER,
            INVALID_PASSWORD
        }
        private readonly ExceptionType type;
        public RegistrationCustomExceptions(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
