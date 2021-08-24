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
    }
}
