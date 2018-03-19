using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_035
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //resultLabel.Text = "<p style=\"color:#ee3b32;\">Hi</p>";

            string value = valueTextBox.Text;

            //Access any specific character:
            //This treats the string like an array,
            //which is basically what it is in memory, allowing you to access any character
            //This might not be the best way to do this, because it can be confusing:
            //resultLabel.Text = value[2].ToString();

            //Some helper methods that will allow you to find strings:
            //StartWith(), EndWith(), Contains()
            /*
            if (value.StartsWith("A"))
                resultLabel.Text = "Value starts with 'A'";

            if (value.EndsWith("."))
                resultLabel.Text += "<br />Value ends with '.'";

            if (value.Contains("good"))
                resultLabel.Text = "Value contains 'good'.";
                */

            //How to show the position of a given string when the first character appears:
            //Indexof()
            /*
             * 
            int index = value.IndexOf("good");
            resultLabel.Text = "'good' begins at index " + index.ToString();
            //In this example, if you type in what is good? The result label shows
            //that the word good starts at index 8.
            */

            //Now that you have the value of that index, you can use it in other ways, such as:
            //Insert(), Remove()
            //int index = value.IndexOf("good");
            //resultLabel.Text = value.Insert(index, "jolly ");
            //In this example, the word jolly will be inserted before the word good.


            //Remove() has a couple of overloads, the used here is count 
            //(how many characters do you want to remove after starting at the 
            //IndexOf character. 
            //int index = value.IndexOf("good");
            //resultLabel.Text = value.Remove(index, value.Length - index);

            //This will allow you to pull back characters at any given index for a given length:
            //Substring()
            //int index = value.IndexOf("good");
            //resultLabel.Text = value.Substring(index, value.Length - index - 1);

            //Using Trim(), TrimStart(), TrimEnd()
            //int index = value.IndexOf("good");
            //resultLabel.Text = String.Format("Length Before: {0}<br /> Length After: {1}", value.Length, value.Trim().Length);
            //In this scenario, if you typed in three spaces, then bob, then three spaces,
            //you would get back 9 spaces before and three after.
            //This is useful for comparing two strings, comparing a string you expect the user to input
            //versus a string that they actually type in.


            //PadLeft(), PadRight():
            //When you need to pass in a char, you use two single quotes instead 
            //of two double quotes that are used for strings.
            //int index = value.IndexOf("good");
            //resultLabel.Text = value.PadLeft(10, '*');
            //This example shows how you can add characters before a set of numbers typed it.


            //ToUpper(), ToLower()
            //Rule: Whenever you compare strings, case matters.
            //if ("bob" == "Bob") resultLabel.Text = "The same.";
            //else resultLabel.Text = "Different.";
            //This shows that they are different.

            //if (valueTextBox.Text.Trim().ToUpper() == "BOB") resultLabel.Text = "The same.";
            //else resultLabel.Text = "Different.";
            //If you type in bob in the textbox, it will say that they are the same 
            //because it makes it uppercase and compare BOB to BOB.

            //This is exetremely helpful whenever you are cleaning up data, such as in 
            //an XML file, text file, or something like that. You need to replace characters
            //that your system doesn't accept with ones that it does.
            //Replace()
            //string template = "[NAME] said it woud be okay. Maybe you should take that up with [NAME].";
            //resultLabel.Text = template.Replace("[NAME]", valueTextBox.Text);
            //If you were to type in Bob in the textbox, Bob would replace [NAME].


            //Take one string and split it up into an array of strings whenever it finds
            //a specific characters, like a comma, semicolon, or any character you choose.
            //Split()
            //A comma is a char, so use single quotes:
            /*
            string result = "";
            string[] values = valueTextBox.Text.Split(',');
            for (int i = 0; i < values.Length; i++)
            {
                result += values[i] + " " + values[i].Length + "<br />";
           } 
            resultLabel.Text = result;
            */

            //Since strings are arrays of characters, if you want to make a string bigger
            //ASP.NET has to copy the old and add into a new to append to the larger string
            //exactly like an array, then delete the old. To get around this, there is a 
            //class in the ASP.NET Library called string builder, and it is a very efficient
            //way to append strings together. An example:

            //In order to use StringBuilder, you have to use the lightbulb
            //(contextual menu) and select using System.Text; which will generate
            //using System.Text; up at the start of the program.

            StringBuilder sb = new StringBuilder();
            string[] values = valueTextBox.Text.Trim().Split(',');
            for (int i = 0; i < values.Length; i++)
            {
                //This result += values[i] + " " + values[i].Length + "<br />"; turns into:
                sb.Append(values[i]);
                sb.Append(" ");
                sb.Append(values[i].Length);
                sb.Append("<br />");
            }
            //This resultLabel.Text = result; turns into:
            resultLabel.Text = sb.ToString();
            //This converts the result back into a string value which is needed by the 
            //Text property of the resultLabel.
            //This is a more memory efficient way to concatenate strings. 
            //If you only have a couple of dozen, then you don't need to use the StringBuilder.
            //You don't really get the value out of it and is considered premature optimization.



        }
    }
}