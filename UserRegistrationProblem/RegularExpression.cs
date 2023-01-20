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
        public string input;
        //public RegularExpression()
        //{

        //}
        public RegularExpression(string input)
        {
            this.input = input;
        }
        public string TestMethod(string input, string pattern)
        {
            try
            {
                if (Regex.IsMatch(input, pattern))
                {
                    return "Valid";
                }
                else if (input.Equals(string.Empty))
                {
                    Console.WriteLine();
                    throw new CustomRegularExpressionException("Input should not be empty", CustomRegularExpressionException.ExceptionTypes.NULL_INPUT);
                }
                else
                {
                    return "Invalid";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomRegularExpressionException("Input should not be null", CustomRegularExpressionException.ExceptionTypes.NULL_INPUT);
            }
        }
        //UC1 Validate First Name
        public  string  FirstName()
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            return TestMethod(input, pattern);
        }
        //UC2 Validate Last Name
        public  string  LastName()
        {
            string pattern = "^[A-Z]{1}[a-z]{3,}$";
            return TestMethod(input, pattern);
        }
        //UC3 Validate Email
        public string Email()
        {
            string pattern = "^[a-zA-Z0-9]+([.,-][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
            return TestMethod(input, pattern);
        }
        //UC4 Validate Mobile Number
        public string MobileNo()
        {
            string pattern = "^[6-9]{1}[0-9]{9}$";
            return TestMethod( input,pattern);
        }
        //UC5 Validate Password minimum 8 charactor         "^[a-zA-Z0-9]{8,}$";
        //UC6 AtLeast 1 UpperCase                           "^(?=.*?[A-Z]).{8,}$";  
        //UC7 AtLeast 1 numeric                             "^(?=.*?[A-Z])(?=.*?[0-9]).{8,}$";
        //UC8 AtLeast 1 special character
        public string Password()
        {
            string pattern = "^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[a-z])(?=.*?[#?!@$%^&*-]).{8,}$";
            return TestMethod(input, pattern);
        }
        //UC9 Validate Email Samples
        public string EmailSample()
        {
            string pattern = "^[a-zA-Z0-9]+([.,-][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
            return TestMethod(input , pattern);
        }
    }
}
