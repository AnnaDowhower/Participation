using System;

namespace Coin_Toss
{
    class Program
    {
        static void Main(string[] args)
        {

            //Name Variables
            string answer, rString;
            int H, T, rNum;
            Random R;
          
            //Ask user
            Console.WriteLine("Heads or Tails? >>");
            answer = Console.ReadLine();
    
            //Generate 1 or 2
            R = new Random();
            rNum = R.Next(1, 3);

            //convert 1 or 2 to string
            if (rNum == 1)
            {
                rNum = Convert.ToString(rString);
            }
            else if (rNum == 2)
            {
                rNum = Convert.ToString(rSting);
            }

            //tell user outcome
            if (ans == rNum)
            {
                Console.WriteLine($"{ans}, You guessed right");
            }

            else if (ans != rNum)
            {
                Console.WriteLine($"{ans}, Bad guess");
            }
          
          
        }
    }
}
