using System;
using System.Collections.Generic;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();

            string answer;

            do
            {
                Console.WriteLine("Please enter your exam grade >>");
                double grade = Convert.ToDouble(Console.ReadLine());
                grades.Add(grade);

                Console.WriteLine("Do you have another grade to enter? yes or no >>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');

            double sum = 0, avg;

            foreach (double grade in grades)
            {
                sum += grade;
            }

            avg = sum / grades.Count;
            Console.WriteLine($"Your average grade is {avg.ToString("N2")}");

        }
    }
}
