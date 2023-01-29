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
        public string emailId = "^[a-zA-Z0-9]+([.,-][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
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

        // Validate First Name
        public bool FirstName(string firstname) => (Regex.IsMatch(input, firstName)) ?true : throw new UserException("Invalid First Name", UserException.ExceptionType.INVALID_FIRST_NAME);
        // Validate Last Name
        public bool LastName(string lastname) => (Regex.IsMatch(input, lastName)) ?true : throw new UserException("Invalid Last Name", UserException.ExceptionType.INVALID_LAST_NAME);
        // Validate Email
        public bool Email(string email) => (Regex.IsMatch(input, emailId)) ?true : throw new UserException("Invalid Email Id", UserException.ExceptionType.INVALID_EMAIL);
        // Validate Mobile Number
        public bool MobileNo(string mobileno) => (Regex.IsMatch(input, mobileNumber)) ?true : throw new UserException("Invalid Mobile Number", UserException.ExceptionType.INVALID_MOBILE_NUMBER);
        // Validate Password
        public bool Password(string userPassword) => (Regex.IsMatch(input, password)) ?true : throw new UserException("Invalid Password", UserException.ExceptionType.INVALID_PASSWORD);
        // Validate Email Samples
        public bool EmailSample(string emails) => ( Regex.IsMatch(input , emailSample)) ?true : throw new UserException("Invalid Email Id", UserException.ExceptionType.INVALID_EMAIL);
    }
}
