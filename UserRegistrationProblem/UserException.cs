using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class UserException : Exception
    {
        public ExceptionType exceptionType;
        public enum ExceptionType
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_EMAIL,
            INVALID_MOBILE_NUMBER,
            INVALID_PASSWORD
        }
        public UserException(string msg, ExceptionType exceptionType) : base(msg)
        {
            this.exceptionType = exceptionType;
            Console.WriteLine(msg);
        }
    }
}
