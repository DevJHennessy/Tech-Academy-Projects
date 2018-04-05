using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_29_VarKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using the var keyword to instantiate a new dictionary.
            var newDictionary = new Dictionary<string, string>();
            //The rule of thumb when using var: if ever the datatype is in question, then 
            //you would want to declare the datatype at the beginning for readability.

            //You can declare constants in c#:
            const string casinoName = "Grand Hotel and Casino";
            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            //If you were reference the const several times in the program, then it would be
            //nice to have the constant input, because then you wouldn't worry about user
            //input or someone else using the code would change the name. While the program
            //is running, you know the name will never change. 

            //GUID's are Globally Unique Identifiers. They are used primarily for giving unique
            //ID's to users in databases. 
            Guid identifier = Guid.NewGuid();
            Console.WriteLine(identifier);
            Console.ReadLine();



        }
    }
}
