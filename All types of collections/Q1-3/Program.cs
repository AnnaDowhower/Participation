using System;
using System.Collections.Generic;

namespace Q1_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
    //Question 1            
            string[] name = new string[3];
            string[] courseNum = new string[3];

            Console.WriteLine("You will enter the name of a course and then the course number for 3 total courses. (6 entries)");

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("What is the name of your class? (e.g. MIS, MATH, etc.) >>");
                name[i] = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("What is the course number for that class? (e.g. 3033, 3013, etc.) >>");
                courseNum[i] = Console.ReadLine();

                Console.WriteLine();
            }

            List<string> courseNames = new List<string>();

            for (int i = 0; i <= 2; i++)
            {
                courseNames.Add($"{name[i]}{ courseNum[i]}");
            }

            Console.WriteLine("The full course names are as follows:");

            foreach (var course in courseNames)
            {
                Console.WriteLine(course);
            }
            Console.WriteLine();

    //Question 2
            List<double> c1grades = new List<double>();
            List<double> c2grades = new List<double>();
            List<double> c3grades = new List<double>();

            double sumC1=0, sumC2=0, sumC3=0, avgC1, avgC2, avgC3;
            string answer="";
           
        //c1
                do
                {
                    Console.WriteLine($"Please enter an exam grade for {courseNames[0]}>>");
                    double c1grade = Convert.ToDouble(Console.ReadLine());
                    c1grades.Add(c1grade);
                    sumC1 += c1grade;
                    Console.WriteLine("Do you have more grades for this class? yes or no >>");
                    answer = Console.ReadLine();
                } while (answer.ToLower()[0] == 'y');
                Console.WriteLine();
                avgC1 = sumC1 / (c1grades.Count*100);
        //c2
                do
                {
                    Console.WriteLine($"Please enter your exam grade for {courseNames[1]}>>");
                    double c2grade = Convert.ToDouble(Console.ReadLine());
                    c2grades.Add(c2grade);
                    sumC2 += c2grade;
                    Console.WriteLine("Do you have more grades for this class? yes or no >>");
                    answer = Console.ReadLine();
                } while (answer.ToLower()[0] == 'y');
                Console.WriteLine();
                avgC2 = sumC2 / (c2grades.Count*100);
        //c3
            do
                {
                    Console.WriteLine($"Please enter your exam grade for {courseNames[2]}>>");
                    double c3grade = Convert.ToDouble(Console.ReadLine());
                    c3grades.Add(c3grade);
                    sumC3 += c3grade;
                    Console.WriteLine("Do you have more grades for this class? yes or no >>");
                    answer = Console.ReadLine();
                } while (answer.ToLower()[0] == 'y');
                avgC3 = sumC3 / (c3grades.Count*100);

            //Question 3
            Dictionary<string, List<double>> courseGrades = new Dictionary<string, List<double>>();

           
                AddtoDictionary(courseGrades, courseNames[0], c1grades);
                AddtoDictionary(courseGrades, courseNames[1], c2grades);
                AddtoDictionary(courseGrades, courseNames[2], c3grades);


            Console.WriteLine($"Your average grade for {courseNames[0]} is {avgC1.ToString("P2")}");
            Console.WriteLine($"Your average grade for {courseNames[1]} is {avgC2.ToString("P2")}");
            Console.WriteLine($"Your average grade for {courseNames[2]} is {avgC3.ToString("P2")}");


        }
        static void AddtoDictionary(Dictionary<string, List<double>> myDictionary, string theKey, List<double> ListOfGrades)
        {

            if (!myDictionary.ContainsKey(theKey))
            {
                myDictionary.Add(theKey, ListOfGrades);
            }
            else
            {
                Console.WriteLine("Key already exists, bye");
                return;
            }

           

        }
    }
}
