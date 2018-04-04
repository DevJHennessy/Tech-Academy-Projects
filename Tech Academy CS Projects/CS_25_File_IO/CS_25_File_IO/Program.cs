using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CS_25_File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Here is some text.";
            //Makes a text file called log in the folder Log.
            //File.WriteAllText(@"C:\Users\Student\Logs\log.txt");
            //If you hover over 'text' you see "Here is some text."

            File.ReadAllText(@"C:\Users\Student\Logs\log.txt");
            Console.ReadLine();

        }
    }
}
