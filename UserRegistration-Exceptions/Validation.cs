using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration_Exceptions
{
    public class Validation
    {
        const string REGEX_NAME = "^[A-Z]{1}[A-Za-z]{2,}";
        public void FirstName(string firstName)
        {                       
            if (Regex.IsMatch(firstName, REGEX_NAME) == false)         
                throw new ExceptionHandling(ExceptionHandling.ExceptionsCustomMessage.INVALID_INPUT, " : Name start with Capital and has Minimum 3 characters");         
        }
    }
}
