using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
/*            Console.WriteLine("Welcome to Tic-Tac-Toe!!!\n");

            Console.Write("Please enter the name of Player 1 : ");
            string playerOne = Console.ReadLine();

            Console.Write("Please enter the name of Player 2 : ");
            string playerTwo = Console.ReadLine();*/


            //Console.WriteLine(new GameBoard());
            GameBoard newBoard = new GameBoard();

          //  Console.WriteLine("{0} Make your move", playerOne);

            string move = Console.ReadLine();
            newBoard.Board(move);

            Console.ReadLine();


















        }
    }
}
