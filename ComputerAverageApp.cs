using System;

namespace ComputerAverageProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Allowing the user to input
            Console.WriteLine("Enter five(5) grades seperated by new line: ");
            double gradescr1 = Convert.ToDouble(Console.ReadLine());
            double gradescr2 = Convert.ToDouble(Console.ReadLine());
            double gradescr3 = Convert.ToDouble(Console.ReadLine());
            double gradescr4 = Convert.ToDouble(Console.ReadLine());
            double gradescr5 = Convert.ToDouble(Console.ReadLine());

            //To get the average grade 
            double sum = gradescr1 + gradescr2 + gradescr3 + gradescr4 + gradescr5;
            double averageScore = sum / 5;
            double averageRounded = Math.Round(averageScore); //to get the round of the average

            Console.WriteLine("The Average Grade is: " + averageScore);
            Console.WriteLine("The Round-off Average Grade is: " + (averageRounded));
            Console.WriteLine("Thank you!");

        }
    }
}
