using System;

namespace DataTypesProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Allowing the user to input
            Console.Write("Enter the pieces of apple: ");
            int pcs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the total price of the apple(s): ");
            double price = Convert.ToDouble(Console.ReadLine());    
            double wholenum = Math.Round(price, 1); 

            // To print the total and the values of the original and converted prices
            Console.WriteLine("The total price of " + pcs + " apple(s) is " + wholenum);
            Console.WriteLine("Value of Original Price: " + price);

            int finalvalue = (int)wholenum;
            Console.WriteLine("Value of Converted Price: "+finalvalue);
            Console.WriteLine("Thank You!");
        }
    }
}
