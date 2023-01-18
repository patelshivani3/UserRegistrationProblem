﻿using System;
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
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            return TestMethod(input, pattern);
        }
        //UC2 Validate Last Name
        public  string  LastName(string input)
        {
            string pattern = "^[A-Z]{1}[a-z]{3,}$";
            return TestMethod(input, pattern);
        }
        //UC3 Validate Email
        public string Email(string input)
        {
            string pattern = "^[a-zA-Z0-9]+([.,-][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
            return TestMethod(input, pattern);
        }
    }
}
