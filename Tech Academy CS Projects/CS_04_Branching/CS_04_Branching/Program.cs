using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_04_Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //If else statements
            //int currentTemperature = 70;
            //int roomTemperature = 90;

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is NOT room temp.";
            //Console.WriteLine(comparisonResult);


            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room temperature is warmer than current temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("It is NOT exactly room temperature.");
            //}

            //int roomTemperature = 70;
            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhhh....something went wrong.");
            //}

            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());
            string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number.";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
