using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program:
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //
            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //Console.WriteLine("Your favorite number is: " + favoriteNumber);
            //Console.ReadLine();

            //Converting string to int to perform math operations:
            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus five is: " + total);
            //Console.ReadLine();

            //Datatypes:
            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -21;
            //Char represents unicode character and used with single quotes:
            char randomLetter = 'X';
            char questionMark = '\u2103'; //This makes a question mark.


            //Console.WriteLine(questionMark);
            //Console.ReadLine();

            decimal moneyInBank = 100.5m; //Compilier needs m to understand decimal.

            double heightInCentimeters = 211.30483083;

            float secondsLeft = 2.62f; //Compilier needs f to understand float.

            short temperatureOnMars = -341; //Shorter than integer.

            //Converting from integer to string:
            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            //Converting/Casting bool to string (will show true as a string):
            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);

            Console.WriteLine(rainingStatus);
            Console.ReadLine();


        }
    }
}
