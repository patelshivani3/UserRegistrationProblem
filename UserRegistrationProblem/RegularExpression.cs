using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class RegularExpression
    {
        public string TestMethod(string input, string pattern)
        {
            if (Regex.IsMatch(input, pattern))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
        //UC1 Validate First Name
        public  string  FirstName(string input)
        {
            string pattern = "^[a-zA-Z]{3,}$";
            return TestMethod(input, pattern);
        }
        //UC2 Validate Last Name
        public  string  LastName(string input)
        {
            string pattern = "^[a-zA-Z]{3,}$";
            return TestMethod(input, pattern);
        }
    }
}
