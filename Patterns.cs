using System;
using System.Text.RegularExpressions;

public class Patterns
{

    public void ValidatePinCode(string pincode)
    {
        var regex = new Regex("^[1-9][0-9]{5}$");
        bool isValid = regex.IsMatch(pincode);
        if (isValid == true)
        {
            Console.WriteLine($"\n{pincode} is  valid");
        }
        else
        {
            Console.WriteLine($"\n{pincode} is invalid");
        }
    }
}
