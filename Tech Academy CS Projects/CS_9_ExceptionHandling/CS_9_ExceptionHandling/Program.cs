using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_9_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            //Try-catch-finally block:
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two... \n");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals: " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {

               //Console.WriteLine("\n" + ex.Message);
                Console.WriteLine("\nPlease type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("\nPlease don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n" + ex.Message);

            }
            finally
            {
                //Often in a finally you have a database log. You log that something 
                //happened or that there was an exception. If, for example, you were
                //charging a credit card, you would want to log it no matter if an 
                //exception happened or not.
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
