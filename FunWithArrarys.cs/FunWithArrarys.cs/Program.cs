using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrarys.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            prog.IterateString();
            Console.ReadLine();
            

            SplitString();
            Console.ReadLine();

            prog.simpleArrary();
            Console.ReadLine();

            prog.ReverseString();
            Console.ReadLine();

            prog.DeclareImplicitArrary();
            Console.ReadLine();

            prog.RectMultiDimentArrary();
            Console.ReadLine();

            prog.JaggedMultiArrary();
            Console.ReadLine();

        }

        public void IterateString()
        {
            string s1 = "this is a string of characters.";

            foreach (char c in s1)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(s1.Length);
        }

        public static void SplitString()
        {
            Console.Clear();
            string[] words = "this is a sentance.".Split(' ');
            foreach (string word in words) 
            {
                Console.WriteLine(word);
            }
        }

        public void simpleArrary()
        {
            int[] myInt = new int[3];
            myInt[0] = 100;
            myInt[1] = 200;

            foreach (int i in myInt)
            {
                Console.WriteLine(i);
            }
        }

        public void ReverseString()
        {
            //remember this!!!

            string myString = "String to reverse";

            for (int i = 0; i < myString.Length; i++)
            {
                Console.Write(myString[myString.Length - i - 1]);
            }

            Console.WriteLine();

            for (int i = myString.Length - 1; i >= 0; i--)
            {
                Console.Write(myString[i]);
            }

        }

        public void DeclareImplicitArrary()
        {
            var a = new[] {1, 10, 100, 1000};
            Console.WriteLine("a is a: {0}", a.ToString());

            var b = new[] {1, 1.5, 2, 2.5};
            Console.WriteLine("b is b: {0}", b.ToString());

            var c = new[] {"hello world"};
            Console.WriteLine("c is c: {0}", c.ToString());
        }

        public void RectMultiDimentArrary()
        {
            int[,] myGrid = new int[5,6];

            for (int i = 0; i < 5; i ++)
            {
                for (int j = 0; j < 6; j++)
                {
                    myGrid[i, j] = i*j;
                }
            }


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(myGrid[i,j] + "\t");
                }

                Console.WriteLine();
            }


        }

        public void JaggedMultiArrary()
        {
            Console.Clear();
            int[][] myJaggedArrary = new int[5][];

            for (int i = 0; i < myJaggedArrary.Length; i++)
            {
                myJaggedArrary[i] = new int[i + 3];
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJaggedArrary[i].Length; j++)
                {
                    Console.Write(myJaggedArrary[i][j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
