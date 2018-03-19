using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_026
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            /* Creating a FOR LOOP in C#
               int i = 0 initializes i at 0.
               Check to see if i is less than 10.
               At the end of the loop, add 1.
               Add result to i and cast it as a string (it was declared as an int).
               This will count out 0 through 9 and stop when i is no longer less than 10.
               At this point the program will exit the FOR LOOP code block and display the results.
             */

            /*
            for(int i = 0; i < 10; i++)
            {
                result += "<br>" + i.ToString();
            }
            */

            //You can start anywhere and set it <= as well.
            /*
            for (int i = 5; i <= 15; i++)
            {
                result += "<br>" + i.ToString();
            }
            */

            /*
             Tip, if you type in for and hit tab twice, 
             Visual Studio creates a template to follow.
             Other words also have code snippets than can be
             inserted if tabbed, such as if.
             */

            //You don't just have to go forward, you can also go backward:
            /*
            for (int i = 15; i >= 5; i--)
            {
                result += "<br>" + i.ToString();
            }
            */

            //You don't just have to go up by one each time:
            /*
            for (int i = 5; i <= 15; i+=3)
            {
                result += "<br>" + i.ToString();
            }
            */

            //Make sure .Lenght is capitalized.
            /* Working with arrays. This will go through the for loop 
             * as long as i is less than the length of the array.
             */ 
            string[] names = new string[] { "Wolverine", "Cyclops", "Professor X", "Phoenix" };

            /* This sorts the names in alphabetical order
            Array.Sort(names);
            */
            /* This will reverse the order that the names are currently in.
            Array.Reverse(names);

            Note: if you wanted to sort alphabetically in descending order,
            you would use both together like this:
            Array.Sort(names);
            Array.Reverse(names);
            */

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "Professor X")
                {
                    result = String.Format("{0} is at index {1} in the list", names[i], i);
                    //Using the break will end the loop once it has found what it is looking for:
                    break;
                }
            }



            /*
            for (int i = 0; i < names.Length; i++)
            {
                result += "<br>" + names[i];
            }
            */


            resultLabel.Text = result;
        }
    }
}