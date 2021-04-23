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

                    Console.WriteLine("What is the name of the toy in this box? >>");
                    toy.Name = Console.ReadLine();
                    Console.WriteLine("Who is its manufacturer? >>");
                    toy.Manufacturer = Console.ReadLine();
                    Console.WriteLine("What is its price? >> ");
                    toy.Price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Toy note / description >>");
                    toy.SetNote(Console.ReadLine());
                    toyBox.Toys.Add(toy);

                    Console.WriteLine("Is there another toy in this box? >>");
                    answer = Console.ReadLine().ToLower();

                } while (answer[0] == 'y');

                boxes.Add(toyBox);

                Console.WriteLine("Do you have another Toy Box? >>");
                answer = Console.ReadLine().ToLower();

            } while (answer[0] == 'y');

            //outputs all toybox and toy info
            foreach (var box in boxes)
            {
                Console.WriteLine(box);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("It holds the following items:");
                Console.ForegroundColor = ConsoleColor.White;

                foreach (var toy in box.Toys)
                {
                    Console.WriteLine(toy);
                    Console.WriteLine();
                }
            }

            //generate random toy from each box
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The following are a random toy from each toy box:");
            foreach (var box in boxes)
            {
                Console.WriteLine(box);
                Toy r = box.GetRandomToy();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(r);
                Console.WriteLine();
            }
        }
    }
}
