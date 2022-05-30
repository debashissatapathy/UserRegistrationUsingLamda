using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingLambda
{
    public class UserRegistration
    {
        string FirstName = @"[A-Z]{1}[a-z]{2,}$";
        string LastName = @"[A-Z]{1}[a-z]{2,}$";
        string Email_Id = @"^[A-Za-z0-9]+.[A-Za-z0-9]+@[A-Za-z0-9]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        string PhoneNumber = @"[0-9]{2}[ ]{1}[6-9]{1}[0-9]{9}";
        string Password = "^(?=.*[@#$%0-9A-Z])[@#$%0-9a-zA-Z]{8,}$";
        public string FirstNameUsingLambda(string firstname) => Regex.IsMatch(firstname, FirstName) ? "First Name is valid" : "Invalid First Name";
        public string LastNameUsingLambda(string lastname) => Regex.IsMatch(lastname, LastName) ? "Last Name is valid" : "Invalid Last Name";

        public string EmailusingLambda(string email) => Regex.IsMatch(email, Email_Id) ? "Email is Valid" : "Invalid Email";
        public string PhoneNumberUsingLmbda(string phonenumber) => Regex.IsMatch(phonenumber, PhoneNumber) ? "Phone number is valid" : "Invalid Phone number";
        public string PasswordUsingLambda(string password) => Regex.IsMatch(password, Password) ? "Password is Valid!" : "Invallid Password";


    }
}
