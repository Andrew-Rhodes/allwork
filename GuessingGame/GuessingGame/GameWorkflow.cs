using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public class GameWorkflow
    {
        private Random _randGenerator = new Random();

        public void PlayGame(string playerName)
        {
            int numberToGuess = _randGenerator.Next(1, 21);

            bool guessedCorrectly = false;
            int guesses = 0;

            do
            {
                Console.Write($"{playerName},  enter a number between 1-20: (Q to quit)");
                string guess = Console.ReadLine();

                if (guess.ToUpper() == "Q")
                {
                    return;
                }

                int guessInt = int.Parse(guess);
                guesses++;

                if (guessInt == numberToGuess)
                {
                    if (guesses == 1)
                    {
                        Console.WriteLine($"first try {playerName}");
                    }
                    else
                    {
                        Console.WriteLine($"{playerName} GUESSED THE NUMBER");
                    }
                    guessedCorrectly = true;
                }
                else if (guessInt <= 20 && guessInt >= 1)
                {
                    Console.WriteLine($"try again {playerName}");
                }
                else
                {
                    Console.WriteLine("enter a number between 1 and 20");
                }
            } while (!guessedCorrectly);
        }
    }
}
