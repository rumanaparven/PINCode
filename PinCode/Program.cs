using System;


namespace PinCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the PIN Code : ");
            String pin = Console.ReadLine();
            RegexValidation rv = new RegexValidation();
            rv.Validation(pin);
        }
    }
}
