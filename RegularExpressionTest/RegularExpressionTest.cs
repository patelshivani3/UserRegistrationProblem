using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using UserRegistrationProblem;
using UserRegistrationProblem.Reflection;

namespace RegularExpressionTestProject
{
    [TestClass]
    public class RegularExpressionTest
    {
        
        [TestMethod]
        [TestCategory("First Name")]
        [DataRow( "Shivani", true)]
        [DataRow( "123abc", false)]
        public  void ValidateFirstName(string input , bool expected)
        {   
            try 
            {
                //AAA methodology
                //Arrange
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                bool actual = regularExpression.FirstName(input);
              
            }
            catch (UserException ex)
            {
                Assert.AreEqual("Invalid First Name", ex.Message);
            }
        }
            

        [TestMethod]
        [TestCategory("Last Name")]
        [DataRow("Patel", true)]
        [DataRow("123abc", false)]
        public void ValidateLastName(string input, bool expected)
        {
            try
            {
                //AAA methodology
                //Arrange
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                bool actual = regularExpression.LastName(input);
                
            }
            catch (UserException ex)
            {
                Assert.AreEqual("Invalid Last Name", ex.Message);
            }
        }

        [TestMethod]
        [TestCategory("Email")]
        [DataRow("Patel@gmail.com", true)]
        [DataRow("123abc", false)]
        public void ValidateEmail(string input, bool expected)
        {
            try
            {
                //AAA methodology
                //Arrange
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                bool actual = regularExpression.Email(input);
            }
            catch (UserException ex)
            {
                Assert.AreEqual("Invalid Email Id", ex.Message);
            }
        }

        [TestMethod]
        [TestCategory("Mobile Number")]
        [DataRow("7235456770", true)]
        [DataRow("1231233", false)]
        public void ValidateMobileNumber(string input, bool expected)
        {
            try
            {
                //AAA methodology
                //Arrange
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                bool actual = regularExpression.MobileNo(input);
            }
            catch (UserException ex)
            {
                //Assert
                Assert.AreEqual("Invalid Mobile Number", ex.Message);
            }
        }

        [TestMethod]
        [TestCategory("Password")]
        [DataRow("Password@1", true)]
        [DataRow("abcd", false)]
        public void ValidatePassword(string input, bool expected)
        {
            try
            {
                //AAA methodology
                //Arrange
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                bool actual = regularExpression.Password(input);
            }
            catch (UserException ex)
            {
                Assert.AreEqual("Invalid Password", ex.Message);
            }
        }

        [TestMethod]
        [TestCategory("Emails")]
        [DataRow("Patel@gmail.com", true)]
        [DataRow("abc@yahoo.com", true)]
        [DataRow("abc@abc@gmail.com", false)]
        [DataRow("abc123@.com", false)]
        [DataRow("abc", false)]
        public void ValidateEmailSample(string input, bool expected)
        {
            try
            {
                //AAA methodology
                //Arrange
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                bool actual = regularExpression.EmailSample(input);
            }
            catch (UserException ex)
            {
                Assert.AreEqual("Invalid Email Id", ex.Message);
            }
        }
    }
}
