using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Toy
{
    public class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes;
       
        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Notes = "";
        }

        public string GetAisle()
        {
            Random R = new Random();
            int randomNum = R.Next(1, 25);
            return $"{Manufacturer.ToUpper()[0]}{randomNum}";
        }

        public string GetNote()
        {
            return Notes;
        }
        public void SetNote(string details)
        {
            Notes = details;
        }
    }
}
