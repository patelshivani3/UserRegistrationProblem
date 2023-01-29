using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class CustomRegularExpressionException : Exception
    {
        public ExceptionTypes exceptionTypes;
        public enum ExceptionTypes
        {
            NULL_INPUT,
            CLASS_NOT_FOUND,
            NO_SUCH_METHOD
        }
        public CustomRegularExpressionException(string msg, ExceptionTypes exceptionTypes) : base(msg)
        {
            this.exceptionTypes = exceptionTypes;
            Console.WriteLine(msg);
        }
    }
}
