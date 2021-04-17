using System;

namespace Speak
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("What animal do you want to know the sound of? >>");
                string animal = Console.ReadLine().ToLower();

                string sound = Speak(animal);
                Console.WriteLine(sound);

                Console.WriteLine("Do you want to go again? >>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');

            Console.WriteLine("Bye!");
        }

        static string Speak(string animal)
        {
            string sound;
            if (animal == "snake")
            {
                sound = "Ssssss";
            }
            else if (animal == "cow")
            {
                sound = "mooooo";
            }
            else if (animal == "fish")
            {
                sound = "glub glub";
            }
            else if (animal == "fox")
            {
                sound = "wa-pa-pa-pa-pa-pa-pow";
            }
            else
            {
                sound = "bleh";
            }
            return sound;
        }
    }
}
