using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_06_WorkingWithStrings
{
    class Program
    {
        static void Main()
        {
            //How to use double quotes inside a string.
            //You can use the escape character \ which tells the compilier that what
            //follows it is part of the string.
            //string quote = "The man said, \"Hello, John.\"";
            //Console.WriteLine(quote);
            //Console.ReadLine();

            //Another escape character sequence is the NewLine character: \n:
            //\t does a tab indent:
            //string quote = "The man said, \"Hello, John.\" \n Hello on a new line. \n \t Hello on a tab.";
            //Console.WriteLine(quote);
            //Console.ReadLine();


            //Sometimes you want a backslash \ in your string, so there is an escape
            //character for that as well, a double backslash. It's an escape character
            //for itself.
            //string quote = "The man said, \\\"Hello, John.\" \n Hello on a new line. \n \t Hello on a tab.";
            ////This comes in handy for file names:
            //string fileName = "C:\\Users\\John";
            ////Another way to do this is to include an @ before the string, which says
            ////that everything after the @ is part of the string. This is handy if the
            ////file name is really long.
            //string fileName2 = @"C:\Users\John";

            //Console.WriteLine(fileName2);
            //Console.ReadLine();

            //string name = "John Hennessy";
            //bool trueOrFalse = name.Contains("h"); //True
            //trueOrFalse = name.EndsWith("j"); //False

            ////Length is a property of a string:
            //int length = name.Length;

            ////This is great for making user input of states uppercase (or anything you need
            ////uppercase).
            //name = name.ToUpper();
            ////Can also make lowercase:
            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            //string are immutable:
            //string name = "James";
            ////This looks like it is changing the string, but it is actually making a 
            ////whole new string in memory. This is not an efficient use of memory when
            ////you have lots of strings.
            //name = "Bobby";

            //Instead you want to use StringBuilder:
            StringBuilder _sb = new StringBuilder();

            _sb.Append("My name is John.");
            _sb.Append(" It is currently nice outside.");
            _sb.Append(" The sun is out and everything.");
            _sb.Append("\n It is remarkable!");
            
            Console.WriteLine(_sb);
            Console.ReadLine();


        }
    }
}
