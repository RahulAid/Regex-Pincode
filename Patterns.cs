using System;
using System.Text.RegularExpressions;

public class Patterns
{

    public void ValidatePinCode(string pincode)
    {
        var regex = new Regex("^[1-9]{1}[0-9]{2}\\s{0,1}[0-9]{3}$");
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
