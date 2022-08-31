using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegExe
{
    class UserRegex
    {
        public Regex FirstNameReg = new Regex(@"[A-Z][a-zA-Z]{2,}$");
        public Regex LastNameReg = new Regex(@"[A-Z][a-zA-Z]{2,}$");
        public Regex EmailAddress = new Regex(@"^[a-zA-Z0-9]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][A-Za-z]{2,})?$");
        public Regex MobileNumberRegex = new Regex(@"[0-9]{2}\s[0-9]{10}$");
        public Regex Pass = new Regex(@"[A-Z][a-z][0-9][!@#$%^&*]{8,}$");
        public void ValidateFirstName(string FirstName)
        {
            Console.WriteLine("\n First Name: "+FirstName);
            if (FirstNameReg.IsMatch(FirstName))
                Console.WriteLine("Valid First Name");
            else
                Console.WriteLine("Invalid First Name");
        }
        public void ValidateLastName(string LastName)
        {
            Console.WriteLine("\n Last Name: " + LastName);
            if (LastNameReg.IsMatch(LastName))
                Console.WriteLine("Valid Last Name");
            else
                Console.WriteLine("Invalid Last Name");
        }
        public void ValidateMobile(string PhoneNumber)
        {
            Console.WriteLine("\n Mobile number : "+ PhoneNumber);
            if(MobileNumberRegex.IsMatch(PhoneNumber))
            {
                Console.WriteLine("Valid Mobile Number");
            }
            else
            {
                Console.WriteLine("Invalid Mobile Number");
            }
        }

        public void ValidateEmailAddress(String Email)
        {
            Console.WriteLine("\n EmailAddress : " + Email);
            if (EmailAddress.IsMatch(Email))
            {
                Console.WriteLine("Vaild Email Address");
            }
            else
            {
                Console.WriteLine("Invalid email address");
            }
        }

        public void Validate_Password(string password)
        {
            Console.WriteLine("The password is : "+ password);
            if(Pass.IsMatch(password))
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password is Invalid");
            }
        }
    }
}
