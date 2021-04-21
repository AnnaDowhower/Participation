using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes_ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToyBox> boxes = new List<ToyBox>();
            List<Toy> toys = new List<Toy>();
            
            string answer;

            do
            {
                ToyBox toyBox = new ToyBox();

                Console.WriteLine("Who owns this Toy Box? >>");
                toyBox.Owner = Console.ReadLine();
                Console.WriteLine($"Where is this Toy Box located? >>");
                toyBox.Location = Console.ReadLine();

                do
                {
                    Toy toy = new Toy();

                    Console.WriteLine("What is the name of the first toy in this box? >>");
                    toy.Name = Console.ReadLine();
                    Console.WriteLine("Who is its manufacturer? >>");
                    toy.Manufacturer = Console.ReadLine();
                    Console.WriteLine("What is its price? >> ");
                    toy.Price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Toy note / description >>");
                    toy.SetNote(Console.ReadLine());
                    toys.Add(toy);

                    Console.WriteLine("Is there another toy in this box? >>");
                    answer = Console.ReadLine().ToLower();

                } while (answer[0] == 'y');

                boxes.Add(toyBox);

                Console.WriteLine("Do you have another Toy Box? >>");
                answer = Console.ReadLine().ToLower();
         
            } while (answer[0] == 'y');

            for (int i = 0; i < boxes.Count()-1; i++)
            {
                Console.WriteLine(boxes.ToString());
                Console.WriteLine("It holds the following items:");

                for (int j = 0; j < toys.Count()-1; j++)
                {
                    Console.WriteLine(toys.ToString());
                }
            }
            
            
            /* foreach (var Box in boxes)
            {
                Console.WriteLine(Box.ToString());
                Console.WriteLine("It holds the following items:");
                
                foreach (var Toy in toys)
                {
                    Console.WriteLine(Toy.ToString());
                }
            }*/
        }
    }
}
