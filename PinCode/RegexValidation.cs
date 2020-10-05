using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PinCode
{
    class RegexValidation
    {
        public void Validation(String pin)
        {
            Regex reg = new Regex("^[1-9]{1}[0-9]{5}$");
            if (reg.IsMatch(pin))
            {
                Console.WriteLine("The PIN Code is Valid");

            }
            else
            {
                Console.WriteLine("The PIN Code is Invalid");
            }
        }
    }
}
