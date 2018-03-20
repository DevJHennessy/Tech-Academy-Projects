using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_8_Iteration
{
    class Program
    {
        static void Main()
        {

            //Iterating through an integer arrray:
            //int[] testScores = { 98, 99, 85, 82, 70, 60, 50, 58, 97, 89, 87 };

            //For loops have three conditions.
            //The first is the starting value of the variable.
            //The second asks how long you are going to do the loop, the loop duration.
            //The third conditions asks what you want to do after the loop runs through.
            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //Iterating through a string array:
            //string[] names = { "Bean", "Ender", "Megan", "Sally" };

            ////Using j just to show that you can use other variable names.
            //for (int j = 0; j < names.Length; j++)
            //{
            //    //if (names[j] == "Sally")
            //    //{
            //    //    Console.WriteLine(names[j]);
            //    //}

            //    //Looking at all the names:
            //    Console.WriteLine(names[j]);
            //}
            //Console.ReadLine();

            //Iterating through Lists<T>:
            //List<int> testScores = new List<int>();
            //testScores.Add(95);
            //testScores.Add(83);
            //testScores.Add(78);
            //testScores.Add(60);
            //testScores.Add(91);

            ////The variable score repsents the item in the list.
            //foreach (var score in testScores)
            //{
            //    if (score > 85)
            //        Console.WriteLine("Passing test score: " + score);
            //    //if you only have one line to execute, then you don't need squiggly braces.

            //}
            //Console.ReadLine();

            //List of strings:
            //List<string> names = new List<string>()
            //{
            //    "Bob", "Tina", "Linda", "Louise", "Gene"
            //};

            //foreach (var name in names)
            //{
            //    //if (name == "Gene")
            //    //{
            //    //    Console.WriteLine(name);
            //    //}
            //    //Shows all the names:
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            //Adding values from one list to another list:
            List<int> testScores = new List<int> { 95, 88, 40, 79, 91 };
            List<int> passingScores = new List<int>();

            //Foreach score that passes, it will be added to passingScores:
            foreach (var score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            //will show three passing scores:
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
