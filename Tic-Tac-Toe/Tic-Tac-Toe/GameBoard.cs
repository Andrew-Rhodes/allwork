using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class GameBoard
    {
        public void Board(string move)
        {
/*            string a = "1";
            string b = "2";
            string c = "3";
            string d = "4";
            string e = "5";
            string f = "6";
            string g = "7";
            string h = "8";
            string i = "9";

            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + a + "  |  " + b + "  |  " + c + "  ");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("-----------------");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + d + "  |  " + e + "  |  " + f + "  ");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("-----------------");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + g + "  |  " + h + "  |  " + i + "  ");
            Console.WriteLine("     |     |     ");

            if (move == "1")
            {
                a = "x";
            }*/
            int rowNumber = 0;

            for (int i = rowNumber; i < 11; i++)
            {

                //_____|_____|_____
                if (i%2 != 0)
                {
                    for (int j = 1; j <= 17; j++)
                    {
                        if (j%6 != 0)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("|");
                        }
                        rowNumber++;
                    }
                }

                //-----------------
                if (i%5 == 0)
                {
                    for (int k = 1; k <= 17; k++)
                    {
                        Console.Write("-");
                        rowNumber++;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}