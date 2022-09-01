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
            Console.WriteLine("Enter 1 for First name Validation");
            Console.WriteLine("Enter 2 for LAst name Validation");
            Console.WriteLine("Enter 3 for Mobile number Validation");
            Console.WriteLine("Enter 4 for Emial validaton");
            Console.WriteLine("Enter 5 for Password Validation");
            int answer =Convert.ToInt32(Console.ReadLine());
            UserRegex regularEpx = new UserRegex();
            switch (answer)
            {
                case 1: string FirstName = "Prasoon"; regularEpx.ValidateFirstName(FirstName); break;
                case 2: string LastName = "Mishra"; regularEpx.ValidateLastName(LastName); break;
                case 3: string PhoneNumber = "91 8299804757"; regularEpx.ValidateMobile(PhoneNumber); break;
                case 4: string Email = "prrasoon987@gamil.com"; regularEpx.ValidateEmailAddress(Email); break;
                case 5: string Password = "Prasoon@123"; regularEpx.Validate_Password(Password); break;
                default: Console.WriteLine("Invalid Input"); break;

            } 
        }
    }
}