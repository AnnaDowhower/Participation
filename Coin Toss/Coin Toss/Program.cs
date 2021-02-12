using System;

namespace Coin_Toss
{
    class Program
    {
        static void Main(string[] args)
        {

            //Name Variables
            const string dev = "Anna";
            string answer = "", finalA ="";
            int rNum, convertednum = 0;
            Random R;

            //get user input
            Console.WriteLine("Heads or Tails? >>");
            answer = Console.ReadLine();

            //make answer Uppercase and 1st character
            answer = answer.Substring(0, 1);
            answer = answer.ToUpper();
                
            //convert answer to int
            if (answer == "H")
            {
                convertednum = 1;
            }
            else if (answer == "T")
            {
                convertednum = 2;
            }


            //Generate 1 or 2
            R = new Random();
            rNum = R.Next(1, 3);
           

            //converts random number back to full words
            if (rNum == 1)
            {
                finalA = "Heads";
            }
            else if (rNum == 2)
            {
                finalA = "Tails";
            }


            //tell user outcome
            if (convertednum == rNum)
            {
                Console.WriteLine($"{finalA}, You guessed right");
            }
            else if (convertednum != rNum)
            {
                Console.WriteLine($"{finalA}, Bad guess");
            }

            //display developer name
            Console.WriteLine($"{dev}");

          
        }
    }
}
