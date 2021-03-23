using System;
using System.Collections.Generic;

namespace Collections_MinMaxAvgMode
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<double> grades = new List<double>();
            Dictionary<double, int> examGrades = new Dictionary<double, int>();

            string answer;
            double sum = 0, avg;

            do
            {
                Console.WriteLine("Please enter your exam grade >>");
                double grade = Convert.ToDouble(Console.ReadLine());
                grades.Add(grade);

                if (examGrades.ContainsKey(grade) == false)               //for mode
                {
                    examGrades.Add(grade, 1);
                }
                else
                {
                    examGrades[grade] = examGrades[grade] + 1;
                }                                                        //to here

                sum += grade;

                Console.WriteLine("Do you have another grade to enter? yes or no >>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');

            avg = sum /grades.Count;                                    //Avg

            double min = grades[0]; //sets the first vale to the minimum then will test each one after
            double max = grades[0];
            int maxOccurences = 0;

            foreach (double grade in grades)        //min
            {
                if (grade < min)
                {
                    min = grade;
                }
            }
            foreach (double grade in grades)        //max
            {
                if (grade > max)
                {
                    max = grade;
                }
            }

            Console.WriteLine($"Your average exam grade is {avg.ToString("N2")}");
            Console.WriteLine($"Your minimum exam grade is {min.ToString("N2")}");
            Console.WriteLine($"Your maximum exam grade is {max.ToString("N2")}");

            foreach (double key in examGrades.Keys)//to go through the keys
            {
                double grade = key;
                if (examGrades[grade]> maxOccurences)
                {
                    maxOccurences = examGrades[grade];
                }
               
            }
            foreach (double key in examGrades.Keys)//to go through the keys
            {
                double grade = key;
                if (examGrades[grade] == maxOccurences)
                {
                    Console.WriteLine($"The mode is {grade} which occurs {maxOccurences} times");
                }
            }
        }
    }
}
