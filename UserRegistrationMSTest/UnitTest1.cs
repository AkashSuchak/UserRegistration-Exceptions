using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration_Exceptions;

namespace UserRegistrationMSTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// FirstName UC1
        /// </summary>
        /// <param name="firstName"></param>
        [TestMethod]
        [DataRow("akash")]
        public void Given_InvalidInput_FirstName_ThrowExceptionCustomMessage_InvalidInput(string firstName)
        {
            Validation validation = new Validation();                        
            Assert.ThrowsException<ExceptionHandling>(() => validation.FirstName(firstName));
        }
        /// <summary>
        /// Last Name UC2
        /// </summary>
        /// <param name="lastName"></param>
        [TestMethod]
        [DataRow("suchak")]
        public void Given_InvalidInput_LastName_ThrowExceptionCustomMessage_InvalidInput(string lastName)
        {
            Validation validation = new Validation();
            Assert.ThrowsException<ExceptionHandling>(() => validation.LastName(lastName));
        }
        /// <summary>
        /// Email : UC3,9
        /// </summary>
        /// <param name="email"></param>
        [TestMethod]
        
        [DataRow("abc")]
        [DataRow("abc@.com.my")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]
        public void Given_InvalidInput_Email_ThrowExceptionCustomMessage_InvalidInput(string email)
        {
            Validation validation = new Validation();
            Assert.ThrowsException<ExceptionHandling>(() => validation.Email(email));
        }
        /// <summary>
        /// Mobile Number : UC4
        /// </summary>
        /// <param name="mobile"></param>
        [TestMethod]
        [DataRow("9099096400")]
        public void Given_InvalidInput_MobileNumber_ThrowExceptionCustomMessage_InvalidInput(string mobile)
        {
            Validation validation = new Validation();
            Assert.ThrowsException<ExceptionHandling>(() => validation.Mobile(mobile));
        }
        /// <summary>
        /// Password hav Minimum 8 characters,1UpperCase,1 Number, 1 Special Character : UC5,6,7,8
        /// </summary>
        /// <param name="password"></param>
        [TestMethod]
        [DataRow("asUdg1asd")]
        public void Given_InvalidInput_Password_ThrowExceptionCustomMessage_InvalidInput(string password)
        {
            Validation validation = new Validation();
            Assert.ThrowsException<ExceptionHandling>(() => validation.Password(password));
        }
    }
}
