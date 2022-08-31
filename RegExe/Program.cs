using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegExe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("______________Regular Expression _____________");
            UserRegex regularEpx = new UserRegex();
            string FirstName = "Prasoon";
            string LastName = "Mishra";
            string PhoneNumber = "91 8299804757";
            string Email = "prrasoon987@gamil.com";
            string Password = "Prasoon9989@";
            regularEpx.ValidateEmailAddress(Email);
            regularEpx.ValidateFirstName(FirstName);
            regularEpx.ValidateLastName(LastName);
            regularEpx.ValidateMobile(PhoneNumber); 
            regularEpx.Validate_Password(Password);
        }
    }
}