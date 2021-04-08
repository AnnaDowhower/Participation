using System;

namespace Functions_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const string developerName = "Anna Dowhower";
            const string className = "Intro to programming";
            const string date = "April 6, 2021";

            DeveloperName(developerName, className, date);

            double calculation = 0;
            char whatNext;

            do
            {
                Console.WriteLine("What type of calculation do you want to perform? Add, subtract, multiply, divide >>");
                string answer = Console.ReadLine().ToLower();

                while ((answer != "add") && (answer != "subtract") && (answer != "multiply") && (answer != "divide"))
                {
                    Console.WriteLine("Incorrect response, try again >>");
                    answer = Console.ReadLine().ToLower();
                }

                Console.WriteLine("Enter first number >>");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number >>");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (answer == "add")
                {
                    calculation = Add(num1, num2);
                    Console.WriteLine($"{num1.ToString("N")} + {num2.ToString("N")} = {calculation.ToString("N")}");
                }
                else if (answer == "subtract")
                {
                    calculation = Subtract(num1, num2);
                    Console.WriteLine($"{num1.ToString("N")} - {num2.ToString("N")} = {calculation.ToString("N")}");
                }
                else if (answer == "multiply")
                {
                    calculation = Multiply(num1, num2);
                    Console.WriteLine($"{num1.ToString("N")} * {num2.ToString("N")} = {calculation.ToString("N")}");
                }
                else if (answer == "divide")
                {
                    calculation = Divide(num1, num2);
                    Console.WriteLine($"{num1.ToString("N")} / {num2.ToString("N")} = {calculation.ToString("N")}");
                }

                //new calculation, result of previous calculation, stop?

                Console.WriteLine($"Would you A: like to perform a new calculation, B: use {calculation.ToString("N")} in a new calculation, or C: stop? (A, B, or C) >>");
                whatNext = Convert.ToChar(Console.ReadLine().ToUpper());

                while (whatNext == 'B')
                {
                    Console.WriteLine("What type of calculation do you want to perform? Add, subtract, multiply, divide >>");
                    answer = Console.ReadLine().ToLower();

                    while ((answer != "add") && (answer != "subtract") && (answer != "multiply") && (answer != "divide"))
                    {
                        Console.WriteLine("Incorrect response, try again >>");
                        answer = Console.ReadLine().ToLower();
                    }

                    num1 = calculation;

                    Console.WriteLine("Enter second number >>");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    if (answer == "add")
                    {
                        calculation = Add(num1, num2);
                        Console.WriteLine($"{num1.ToString("N")} + {num2.ToString("N")} = {calculation.ToString("N")}");
                    }
                    else if (answer == "subtract")
                    {
                        calculation = Subtract(num1, num2);
                        Console.WriteLine($"{num1.ToString("N")} - {num2.ToString("N")} = {calculation.ToString("N")}");
                    }
                    else if (answer == "multiply")
                    {
                        calculation = Multiply(num1, num2);
                        Console.WriteLine($"{num1.ToString("N")} * {num2.ToString("N")} = {calculation.ToString("N")}");
                    }
                    else if (answer == "divide")
                    {
                        calculation = Divide(num1, num2);
                        Console.WriteLine($"{num1.ToString("N")} / {num2.ToString("N")} = {calculation.ToString("N")}");
                    }
                    Console.WriteLine($"Would you A: like to perform a new calculation, B: use {calculation.ToString("N")} in a new calculation, or C: stop? (A, B, or C) >>");
                    whatNext = Convert.ToChar(Console.ReadLine().ToUpper());

                }
               if (whatNext == 'C')
                {
                    Console.WriteLine("Thank you, Goodbye!");
                }

            } while (whatNext == 'A');

        }


        static double Add(double num1, double num2)
        {
            double num3 = 0;
            num3 = num1 + num2;
            return num3;
        }

        static double Subtract(double num1, double num2)
        {
            double num3 = 0;
            num3 = num1 - num2;
            return num3;
        }

        static double Divide(double num1, double num2)
        {
            double num3 = 0;
            num3 = num1 / num2;
            return num3;
        }

        static double Multiply(double num1, double num2)
        {
            double num3 = 0;
            num3 = num1 * num2;
            return num3;
        }

        static void DeveloperName(string developerName, string className, string date)
        {
            Console.WriteLine($"{developerName} wrote this for the class '{className}' on {date}.");
            Console.WriteLine();
            return;
        }

    }
}
