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
        public  bool  FirstName()
        {
             return Regex.IsMatch(input, firstName);
        }
        //UC2 Validate Last Name
        public  bool  LastName()
        {
            return Regex.IsMatch(input, lastName);
        }
        //UC3 Validate Email
        public bool Email()
        {
            return Regex.IsMatch(input, email);
        }
        //UC4 Validate Mobile Number
        public bool MobileNo()
        {
            return Regex.IsMatch( input, mobileNumber);
        }
        //UC5 Validate Password minimum 8 charactor         "^[a-zA-Z0-9]{8,}$";
        //UC6 AtLeast 1 UpperCase                           "^(?=.*?[A-Z]).{8,}$";  
        //UC7 AtLeast 1 numeric                             "^(?=.*?[A-Z])(?=.*?[0-9]).{8,}$";
        //UC8 AtLeast 1 special character
        public bool Password()
        {
            return Regex.IsMatch(input, password);
        }
        //UC9 Validate Email Samples
        public bool EmailSample()
        {
            return Regex.IsMatch(input , emailSample);
        }
    }
}
