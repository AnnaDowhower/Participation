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
       
        public Toy() //called a constructor bcz no variable type and same name as the class
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
            //say theres a variable called aisle that is the first uppercase letter of manufacturer.
            //You could do aisle = "" + Manufacturer.ToUpper()[0];
            //Or you could do aisle = Manufacturer.ToUpper()[0].ToString;
            //Or could do aisle = "" + Manufacturer.ToUpper()[] + randomNum;
        }

        public string GetNote()
        {
            return Notes;
        }
        public void SetNote(string details)
        {
            Notes = details;
        }
        //For Notes you could also add another method like:
        /* public Toy(string notes) 
            {
                Manufacturer = "";
                Name = "";
                Price = 0;
                Notes = notes;
            }  */
}
}
