using System;

namespace SumOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num1, Num2, Num3, SUM, PRODUCT;
            const double Constant = 7.777;

            Console.WriteLine("Enter any number >>");
            Num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter another number >>");
            Num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a third number >>");
            Num3 = Convert.ToDouble(Console.ReadLine());

            SUM = Num1 + Num2 + Num3;
            Console.WriteLine($"The sum of those three numbers is {SUM:0.000}");

            PRODUCT = SUM * Constant;

            Console.WriteLine($"The product of the sum and 7.777 is {PRODUCT:0.000}");
        }  
    }
}
