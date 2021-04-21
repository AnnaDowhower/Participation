using System;
using System.Collections.Generic;

namespace Classes_Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Toy> toys = new List<Toy>();
            
            //instance 1
            Toy toy1 = new Toy();
            toy1.Manufacturer = "Lego Inc.";
            toy1.Name = "Classic Creative Set";
            toy1.Price = 12.96;
            toy1.SetNote("These blocks will destroy your feet if stepped on.");
            toys.Add(toy1);

            Console.WriteLine($"Aisle : {toy1.GetAisle()}");
            Console.WriteLine($"Toy name : {toy1.Name}");
            Console.WriteLine($"Toy price : {toy1.Price.ToString("C")}");
            Console.WriteLine($"Description : {toy1.GetNote()}");


            Console.WriteLine();

            //instance 2
            Toy toy2 = new Toy();
            toy2.Manufacturer = "Knickerbocker Toy Company";
            toy2.Name = "Raggedy Ann Doll";
            toy2.Price = 30.00;
            toy2.SetNote("These dolls might be haunted");
            toys.Add(toy2);

            Console.WriteLine($"Aisle : {toy2.GetAisle()}");
            Console.WriteLine($"Toy name : {toy2.Name}");
            Console.WriteLine($"Toy price : {toy2.Price.ToString("C")}");
            Console.WriteLine($"Description : {toy2.GetNote()}");


        }
    }
}
