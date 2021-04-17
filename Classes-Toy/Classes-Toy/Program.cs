using System;

namespace Classes_Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance 1
            Toy play = new Toy();
            play.Manufacturer = "Lego Inc.";
            play.Name = "Classic Creative Set";
            play.Price = 12.96;
            play.SetNote("These blocks will destroy your feet if stepped on.");

            Console.WriteLine($"Aisle : {play.GetAisle()}");
            Console.WriteLine($"Toy name : {play.Name}");
            Console.WriteLine($"Toy price : {play.Price.ToString("C")}");
            Console.WriteLine($"Description : {play.GetNote()}");

            Console.WriteLine();

            //instance 2
            play = new Toy();
            play.Manufacturer = "Knickerbocker Toy Company";
            play.Name = "Raggedy Ann Doll";
            play.Price = 30.00;
            play.SetNote("These dolls might be haunted");

            Console.WriteLine($"Aisle : {play.GetAisle()}");
            Console.WriteLine($"Toy name : {play.Name}");
            Console.WriteLine($"Toy price : {play.Price.ToString("C")}");
            Console.WriteLine($"Description : {play.GetNote()}");


        }
    }
}
