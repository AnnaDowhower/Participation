using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_ToyBox
{
    public class ToyBox
    {
        public List<Toy> Toys { get; set; }
        public string Owner { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return ($"{Owner}'s ToyBox is located at {Location}");
        }

        public ToyBox()
        {
            //The constructor should set the List to a new instance of a list as well as set the
            //defaults for the other properties/variables.
            Toys = new List<Toy>();
            Owner = "";
            Location = "";
        }
        /*public Toy GetRandomToy()
        {
            //Gets a random toy from the collections, Toys, and returns it.
            int Amnt = Toys.Count;
            Random R = new Random();
            int randomNum = R.Next(0, Amnt);

        }*/
    }
}
