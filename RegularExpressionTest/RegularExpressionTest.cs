using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationProblem;

namespace RegularExpressionTestProject
{
    [TestClass]
    public class RegularExpressionTest
    {
        [TestMethod]
        [TestCategory("First Name")]
        [DataRow( "Shivani", "Valid")]
        [DataRow( "123abc", "Invalid")]
        public void ValidateFirstName(string input , string expected)
        {
            //AAA methodology
            //Arrange
            RegularExpression regularExpression = new RegularExpression(input);
            //Act
            string actual = regularExpression.FirstName();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Last Name")]
        [DataRow("Patel", "Valid")]
        [DataRow("123abc", "Invalid")]
        public void ValidateLastName(string input, string expected)
        {
            //AAA methodology
            //Arrange
            RegularExpression regularExpression = new RegularExpression(input);
            //Act
            string actual = regularExpression.LastName();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Email")]
        [DataRow("Patel@gmail.com", "Valid")]
        [DataRow("123abc", "Invalid")]
        public void ValidateEmail(string input, string expected)
        {
            //AAA methodology
            //Arrange
            RegularExpression regularExpression = new RegularExpression(input);
            //Act
            string actual = regularExpression.Email();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Mobile Number")]
        [DataRow("7235456770", "Valid")]
        [DataRow("1231233", "Invalid")]
        public void ValidateMobileNumber(string input, string expected)
        {
            //AAA methodology
            //Arrange
            RegularExpression regularExpression = new RegularExpression(input);
            //Act
            string actual = regularExpression.MobileNo();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Password")]
        [DataRow("Password@1", "Valid")]
        [DataRow("abcd", "Invalid")]
        public void ValidatePassword(string input, string expected)
        {
            //AAA methodology
            //Arrange
            RegularExpression regularExpression = new RegularExpression(input);
            //Act
            string actual = regularExpression.Password();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Emails")]
        [DataRow("Patel@gmail.com", "Valid")]
        [DataRow("abc@yahoo.com", "Valid")]
        [DataRow("abc@abc@gmail.com", "Invalid")]
        [DataRow("abc123@.com", "Invalid")]
        [DataRow("abc", "Invalid")]
        public void ValidateEmailSample(string input, string expected)
        {
            //AAA methodology
            //Arrange
            RegularExpression regularExpression = new RegularExpression(input);
            //Act
            string actual = regularExpression.EmailSample();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
