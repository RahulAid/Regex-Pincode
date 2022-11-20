namespace Regex_Pincode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regular Expressions Problems");

            Patterns objPattern = new Patterns();
            objPattern.ValidatePinCode("A400088");
        }
    }
}