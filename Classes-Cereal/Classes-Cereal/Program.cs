using System;
using System.Collections.Generic;
using System.IO;

namespace Classes_Cereal
{
    class Program
    {
        static void Main(string[] args)
        {
            //We want to read in a data set of Cereal information and help answer a few questions for the user.
            //The application should output all of the Cereal information that have a serving size that is 1
            //cup or more.  After you output all those cereals, we also need to inform them which Cereals have
            //100 calories or less per serving.

            string[] lines = File.ReadAllLines("Cereal_Data.txt");
            List<Cereal> bowls = new List<Cereal>();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] breaks = lines[i].Split("|");

                Cereal C = new Cereal();

                C.Name = breaks[0];
                C.Manufacturer = breaks[1];
                C.Calories = Convert.ToDouble(breaks[2]);
                C.Cups = Convert.ToDouble(breaks[3]);

                bowls.Add(C);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The following cereals have a serving size that is 1 cup or more:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Cereal cereal in bowls)
            {
                if ( cereal.Cups >= 1)
                {
                    Console.WriteLine(cereal.ToString());
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The following cereals have 100 calories or less per serving:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Cereal cereal in bowls)
            {
                if (cereal.Calories <= 100)
                {
                    Console.WriteLine(cereal.ToString());
                }
            }


        }
    }
}
