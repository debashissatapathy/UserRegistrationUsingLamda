using UserRegistrationUsingLambda;
using System;

class Program
{
    static void Main(String[] args)
    {
        UserRegistration UR = new UserRegistration();
        Console.WriteLine("Enter first name");
        string FirstName = Console.ReadLine();
        string check = UR.FirstNameUsingLambda(FirstName);
        if (check == "First Name is valid")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(check);
            Console.ResetColor();

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(check);
            Console.ResetColor();
        }
        
        Console.WriteLine("Enter last name");
        string LastName = Console.ReadLine();
        string check2 = UR.LastNameUsingLambda(LastName);
        if (check2 == "Last Name is valid")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(check2);
            Console.ResetColor();

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(check2);
            Console.ResetColor();
        }
        Console.WriteLine("Enter your Email id");
        string Email = Console.ReadLine();
        string check3 = UR.EmailusingLambda(Email);
        if (check3 == "Email is valid")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(check3);
            Console.ResetColor();

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(check3);
            Console.ResetColor();
        }
        Console.WriteLine("Enter your Phone Number");
        string PhoneNumber = Console.ReadLine();
        string check4 = UR.PhoneNumberUsingLmbda(PhoneNumber);
        if (check4 == "Phone number is valid")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(check4);
            Console.ResetColor();

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(check4);
            Console.ResetColor();
        }
        Console.WriteLine("Enter Password");
        string Password = Console.ReadLine();
        string check5 = UR.PasswordUsingLambda(Password);
        if (check5 == "Password is valid")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(check5);
            Console.ResetColor();

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(check5);
            Console.ResetColor();
        }
    }
}









   

