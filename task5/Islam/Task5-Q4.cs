using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a password to validate:");
        string password = Console.ReadLine();

        bool isValid = ValidatePassword(password);

        Console.WriteLine(isValid ? "Password is valid." : "Password is not valid.");

        Console.ReadLine();
    }

    static bool ValidatePassword(string password)
    {
        if (password.Length < 7 || password.Length > 16)
            return false;

        if (!ContainsLowercase(password) || !ContainsUppercase(password) || !ContainsDigit(password))
            return false;

        string specialCharacters = "!@#$%^&*()+=_-{}[]:;\"'<>,.?";

        foreach (char c in specialCharacters)
        {
            if (password.Contains(c))
                return true;
        }

        return false;
    }

    static bool ContainsLowercase(string password)
    {
        return password.Any(char.IsLower);
    }

    static bool ContainsUppercase(string password)
    {
        return password.Any(char.IsUpper);
    }

    static bool ContainsDigit(string password)
    {
        return password.Any(char.IsDigit);
    }
}
