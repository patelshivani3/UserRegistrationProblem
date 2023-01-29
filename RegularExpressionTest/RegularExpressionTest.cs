using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
        public void ValidateFirstName(string input , bool expected)
        {
            //AAA methodology
            //Arrange
            RegularExpression regularExpression = new RegularExpression(input);
            //Act
            bool actual = regularExpression.FirstName();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Last Name")]
        [DataRow("Patel", true)]
        [DataRow("123abc", false)]
        public void ValidateLastName(string input, bool expected)
        {
            //AAA methodology
            //Arrange
            RegularExpression regularExpression = new RegularExpression(input);
            //Act
            bool actual = regularExpression.LastName();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Email")]
        [DataRow("Patel@gmail.com", true)]
        [DataRow("123abc", false)]
        public void ValidateEmail(string input, bool expected)
        {
            //AAA methodology
            //Arrange
            RegularExpression regularExpression = new RegularExpression(input);
            //Act
            bool actual = regularExpression.Email();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Mobile Number")]
        [DataRow("7235456770", true)]
        [DataRow("1231233", false)]
        public void ValidateMobileNumber(string input, bool expected)
        {
            //AAA methodology
            //Arrange
            RegularExpression regularExpression = new RegularExpression(input);
            //Act
            bool actual = regularExpression.MobileNo();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Password")]
        [DataRow("Password@1", true)]
        [DataRow("abcd", false)]
        public void ValidatePassword(string input, bool expected)
        {
            //AAA methodology
            //Arrange
            RegularExpression regularExpression = new RegularExpression(input);
            //Act
            bool actual = regularExpression.Password();
            //Assert
            Assert.AreEqual(expected, actual);
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
            //AAA methodology
            //Arrange
            RegularExpression regularExpression = new RegularExpression(input);
            //Act
            bool actual = regularExpression.EmailSample();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
