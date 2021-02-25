using System;

namespace Guess_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a new console application.   Generate a random number that the user will
             define the minimum value and the maximum value, using the Random (Links to an external site.) class.
            Prompt the user to guess the random number until they successfully guess it.*/


            Console.WriteLine("You will be guessing a random number. What do you want the lowest possible number to be? >>");
            string answer = Console.ReadLine();
            int lowNum;

            while (int.TryParse(answer, out lowNum) == false)
            {
                Console.WriteLine($"{answer} not valid input. Try Again >>");
                answer = Console.ReadLine();
            }

            Console.WriteLine("What do you want the highest possible number to be? >>");
            answer = Console.ReadLine();
            int hiNum; ;

            while (int.TryParse(answer, out hiNum) == false)
            {
                Console.WriteLine($"{answer} not valid input. Try again >>");
                answer = Console.ReadLine();
            }

           
            Random R = new Random();
            int rNum = R.Next(lowNum, hiNum);

            Console.WriteLine($"{rNum}");

            Console.WriteLine();
            Console.WriteLine("Okay, guess a number >>");
            answer = Console.ReadLine();
            int GuessNum;

            while (int.TryParse(answer, out GuessNum) == false)
            {
                Console.WriteLine("Sorry you entered an invalid integer. Enter another number >>");
                answer = Console.ReadLine();
            }

            while (GuessNum!=rNum)
            {
                Console.WriteLine("Wrong, try again >>");
                answer = Console.ReadLine();

                while (int.TryParse(answer, out GuessNum) == false)
                {
                    Console.WriteLine("Sorry you entered an invalid integer. Enter another number >>");
                    answer = Console.ReadLine();
                }

            }

            Console.WriteLine("You guessed it!");


        }
    }
}
