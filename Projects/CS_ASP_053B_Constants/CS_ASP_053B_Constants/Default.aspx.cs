using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_053B_Constants
{
    public partial class Default : System.Web.UI.Page
    {
        //You can declare a Field-level constant here as well. This is useful if
        //you are going to use this particular value throughout several different 
        //methods in the class.

        const string fileExtension = ".html";

        protected void Page_Load(object sender, EventArgs e)
        {
            //Another tool to remove Magic literals, such as magic numbers, 
            //magic bools, magic strings, even class references. Magic refers to 
            //embedding, hardcoding some value, as in some string or number.
            
            //A constant is just like a variable except that it never changes, it is 
            //immutable. Once it's set, it can never be changed. It gives your values
            //longer names that describe its purpose and make the code more readable.
            //Constants can be declared at a local level, but also at a field level.
            //Don't create a constant that you expect to change at any time.

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //Constant Locals:
            //A local constant call hoursPerDay, because there are always 24 hours
            //in a day.
            const int hoursPerDay = 24;

            //Calculate a constant:
            const double daysPerWeek = (double)Calendar.days / (double)Calendar.weeks;
            //At this point, once assigned, daysPerWeek can never be changed.

            //daysPerWeek = 7; //This gives a red underline because you cannot change
            //the constant after it has been set.

            //How to access constants:

            string result = "";
            for (int i = 1; i < daysPerWeek; i++)
            {
                for (int j = 0; j < hoursPerDay; j++)
                {
                    result += String.Format("<p><a href='report-{0}-{1}.{2}'>Day: {0} -- Hour: {1}</a></p>", i, j, fileExtension);
                }
            }
            resultLabel.Text = result;
        }
    }
}