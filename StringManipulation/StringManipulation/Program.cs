using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs,and the universe trying to build bigger and better idiots. So far, the universe is winning.";

            Console.WriteLine(sentence);

            Console.WriteLine();
            Console.WriteLine("What word do you want to look for in the above statement? >>");
            string answer = Console.ReadLine();


            bool b = sentence.Contains(answer);

            while (b == false)
            {
                Console.WriteLine($"Sorry, I could not find your word '{answer}'.");
                Console.WriteLine("Give a different word >>");
                answer = Console.ReadLine();
                b = sentence.Contains(answer);
            }
           

            string backwards = "";
            
            for (int i = answer.Length - 1; i >= 0; i--)
            {
                backwards = backwards + answer[i];
            }
            
            Console.WriteLine($"Your word backwards is '{backwards}'");

            Console.WriteLine();
            Console.WriteLine("What word do you want to replace it with? >>");
            string change = Console.ReadLine();

            string newSentence = sentence.Replace(answer,change);
            
            Console.WriteLine();
            Console.WriteLine($"{newSentence}");


        }
    }
}
