using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MsTestingWithRegularExpression;

namespace MsTesingWithRegex
{
    [TestClass]
    public class UnitTest1
    {
        
        Validation validation;
        [TestInitialize]
        public void SetUp()
        {
            validation = new Validation();
        }
        [TestClass]
        public class UserValidation
        {
            [TestMethod]
            //Checking for multiple first name
            [DataRow("Praful", true)]
            [DataRow("pr", false)]
            [DataRow("praful", false)]
            [DataRow("Pr", false)]
            [DataRow("Pra", true)]
            public void GivenFirstNameValidation(string firstName, bool expected) // Testing for Firstname Validation
            {
                //Arrange
                Validation validation = new Validation();
                //Act
                bool actual = validation.FirstNameValidation(firstName);
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        //Checking for multiple last name
        [DataRow("Rakhade", true)]
        [DataRow("ra", false)]
        [DataRow("rakhade", false)]
        [DataRow("Ra", false)]
        [DataRow("Rak",true)]
        public void GivenLastNameValidation(string lastName, bool expected) // Testing for Lastname Validation
        {
            //Arrange
            Validation validation = new Validation();
            //Act
            bool actual = validation.FirstNameValidation(lastName);
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        //Checking for multiple email samples
        [DataRow("abc123@.com", false)]
        [DataRow("abc@abc@gmail.com", false)]
        [DataRow("abc+100@gmail.com", true)]
        [DataRow("abc@1.com", true)]
        public void GivenEmailValidation(string email, bool expected) // Testing for Email Validation
        {
            //Act
            bool actual = validation.EmailValidation(email);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
