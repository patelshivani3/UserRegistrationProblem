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
        public string firstName = "^[A-Z]{1}[a-z]{2,}$";
        public string lastName = "^[A-Z]{1}[a-z]{3,}$";
        public string email = "^[a-zA-Z0-9]+([.,-][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
        public string mobileNumber = "^[6-9]{1}[0-9]{9}$";
        public string password = "^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[a-z])(?=.*?[#?!@$%^&*-]).{8,}$";
        public string emailSample = "^[a-zA-Z0-9]+([.,-][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
        public RegularExpression()
        {

        }
        public RegularExpression(string input)
        {
            this.input = input;
        }
        
        //UC1 Validate First Name
        public bool FirstName()
        {

            if (Regex.IsMatch(input, firstName))
            {
                return true;
            }
            else
            {
                throw new UserException("Invalid First Name", UserException.ExceptionType.INVALID_FIRST_NAME);
            }

        }
        //UC2 Validate Last Name
        public  bool  LastName()
        {
            if (Regex.IsMatch(input, lastName))
            {
                return true;
            }
            else
            {
                throw new UserException("Invalid Last Name", UserException.ExceptionType.INVALID_LAST_NAME);
            }
        }
        //UC3 Validate Email
        public bool Email()
        {
            if( Regex.IsMatch(input, email))
            {
                return true;
            }
            else
            {
                throw new UserException("Invalid Email Id", UserException.ExceptionType.INVALID_EMAIL);
            }
        }
        //UC4 Validate Mobile Number
        public bool MobileNo()
        {
            if( Regex.IsMatch( input, mobileNumber))
            {
                return true;
            }
            else
            {
                throw new UserException("Invalid Mobile Number", UserException.ExceptionType.INVALID_MOBILE_NUMBER);
            }
        }
        //UC5 Validate Password minimum 8 charactor         "^[a-zA-Z0-9]{8,}$";
        //UC6 AtLeast 1 UpperCase                           "^(?=.*?[A-Z]).{8,}$";  
        //UC7 AtLeast 1 numeric                             "^(?=.*?[A-Z])(?=.*?[0-9]).{8,}$";
        //UC8 AtLeast 1 special character
        public bool Password()
        {
            if( Regex.IsMatch(input, password))
            {
                return true;
            }
            else
            {
                throw new UserException("Invalid Password", UserException.ExceptionType.INVALID_PASSWORD);
            }
        }
        //UC9 Validate Email Samples
        public bool EmailSample()
        {
            if( Regex.IsMatch(input , emailSample))
            {
                return true;
            }
            else
            {
                throw new UserException("Invalid Email Id", UserException.ExceptionType.INVALID_EMAIL);
            }
        }
    }
}
