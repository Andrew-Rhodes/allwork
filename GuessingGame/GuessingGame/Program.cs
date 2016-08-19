using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom");
            Console.WriteLine("what is your name");
            string name = Console.ReadLine();

            bool keeplaying = true;

            do
            {
                GameWorkflow game = new GameWorkflow();
                game.PlayGame(name);

                Console.Write("Would you like to play again?");
                string response = Console.ReadLine();

                keeplaying = TranslteResponse(response);


            } while (keeplaying);

            Console.WriteLine("TY for playing");
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

        static bool TranslteResponse(string response)
        {
            switch (response.ToUpper())
            {
                case "YES":
                case "y":
                case "Sure":
                    return true;
                default:
                    return false;
            }
        }
    }
}
