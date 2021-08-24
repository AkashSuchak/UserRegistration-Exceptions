using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration_Exceptions;

namespace UserRegistrationMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("akash")]
        public void Given_InvalidInput_ThrowExceptionCustomMessage_InvalidInput(string firstName)
        {
            Validation validation = new Validation();                        
            Assert.ThrowsException<ExceptionHandling>(() => validation.FirstName(firstName));
        }
    }
}
