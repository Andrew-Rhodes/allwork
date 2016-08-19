using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FunWithExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // CauseException();
            //  HandleException();
            //  HandleSpecicicException();
            //
            //FinallyExample();
     //       CallStackEx();
     ThrowCustomException();

            Console.ReadLine();
        }

        static void CauseException()
        {
            int x = 17;
            int y = 0;

            Console.WriteLine(x/y);
        }

        static void HandleException()
        {
            try
            {
                CauseException();
            }
            catch
            {
                Console.WriteLine("something bad happened");
            }
            Console.WriteLine("still here");
        }

        static void HandleSpecicicException()
        {
            try
            {
                int[] ints = new int[] {5, 4};
                ints[2] = 20;

                ints[1] = 21;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("youre index is out of range...");
            }

            catch
            {
                Console.WriteLine("exception occured");
                throw;
            }
        }

        static void FinallyExample()
        {
            try
            {
                int x = 3;
                int y = 7;

                Console.WriteLine(x/y);

            }
            catch (DivideByZeroException dex)
            {
                Console.WriteLine("you cannnot divide by zero");

            }

            finally
            {
                Console.WriteLine("finally i get to exe");
            }

        }

        static void CallStackEx()
        {
            try
            {
                Method1();
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("catch clause in CallStackEx for DB0");
            }
            finally
            {
                Console.WriteLine("fianlly clause in CallStackEx");
            }
            Console.WriteLine("still running");
        }

        static void Method1()
        {
            try
            {
                Method2();
            }
            catch (NullReferenceException)
            {

                Console.WriteLine("catch clause in CallStackEx for NullReferanceException");
            }
            finally
            {
                Console.WriteLine("fianlly clause in Mehtod1");
            }
            Console.WriteLine("Method1");
        }

        static void Method2()
        {
            try
            {
                CauseException();
            }
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine("catch clause in method 2 for indexOOF");
            }
            finally
            {
                Console.WriteLine("fianlly clause in Mehtod2");
            }
            Console.WriteLine("Method1");
        }

        static void ThrowCustomException()
        {
            try
            {
                throw new MySpeficExpetion("Not a chance");
            }

            catch (MySpeficExpetion mex)
            {
                Console.WriteLine(mex.Message);
                Console.WriteLine(mex.StackTrace);
                Console.WriteLine(mex.HelpLink);
                
            }
        }
    }
}





