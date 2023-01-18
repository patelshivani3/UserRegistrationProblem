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
            RegularExpression regularExpression = new RegularExpression();
            //Act
            string actual = regularExpression.FirstName(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
