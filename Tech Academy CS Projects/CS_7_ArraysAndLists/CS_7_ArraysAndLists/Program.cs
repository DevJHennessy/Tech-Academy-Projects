using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_7_ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            //Arrays: Arrays have to be instantiated to be used because they are objects.

            //Integer array:
            //Longest way:
            //int[] numArray = new int[5];
            //numArray[0] = 10;
            //numArray[1] = 12;
            //numArray[2] = 5;
            //numArray[3] = 99;
            //numArray[4] = -101;

            //Console.WriteLine(numArray[3]);
            //Console.ReadLine();

            //Shorter way:
            //int[] numArray2 = new int[] { 2, 4, 6, 200, 5000 };
            //Console.WriteLine(numArray2[2]);
            //Console.ReadLine();

            //Shortest way, where you don't initialize the array with the new keyword, 
            //the compilier just figures it out:
            //int[] numArray3 = { 2, 4, 6, 200, 5000 };

            ////You can change values at specific elements:
            //numArray3[3] = 350;

            //Console.WriteLine(numArray3[3]);
            //Console.ReadLine();

            //Lists:
            List<int> intList = new List<int>();
            //Adding to the list:
            intList.Add(4);
            intList.Add(10);
            intList.Remove(10);

            //Showing the value at element zero (0).
            Console.WriteLine(intList[0]);
            Console.ReadLine();

        }
    }
}
