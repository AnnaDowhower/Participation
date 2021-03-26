using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create parallel arrays, one will have the course subject(e.g.MIS, MATH, etc.) and the other will hold course
            //numbers(e.g. 3033, 3013, etc.).Ask the user to input 3 for each, store them in the array.Then use a different
            //loop to output the results to the user concatenated together(e.g.MIS3033, MATH3013).


            string[] courseName = new string[3];
            string[] courseNum = new string[3];

            Console.WriteLine("You will enter the name of a course and then the course number for 3 total courses. (6 entries)");

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("What is the name of your class? (e.g. MIS, MATH, etc.) >>");
                courseName[i] = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("What is the course number for that class? (e.g. 3033, 3013, etc.) >>");
                courseNum[i] = Console.ReadLine();

                Console.WriteLine();
            }

            Console.WriteLine("The full course names are as follows:");

            for (int i = 0; i <=2 ; i++)
            {
                Console.WriteLine($"{courseName[i]}{courseNum[i]}");
            }
            


        }
    }
}
