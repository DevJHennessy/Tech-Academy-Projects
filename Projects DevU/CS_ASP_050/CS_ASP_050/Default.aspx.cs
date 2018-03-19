using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_050
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            List<Car> cars = new List<Car>() {
                new Car { Make = "BMW", Model = "528i", Year = 2010, Color = "White" },
                new Car { Make = "BMW", Model = "745li", Year = 2005, Color = "Black" },
                new Car { Make = "Ford", Model = "Escape", Year = 2008, Color = "White" }
            };

            /*A for statement works, but not as well as a foreach statement:
            for (int i = 0; i < cars.Count; i++)
            {
                result += cars.ElementAt(i).FormatDetailsForDisplay();
            }
            */

            //In cases where you want to loop through each member of the collection in order
            //to access it properties and its methods.
            //foreach tab tab brings up the code snippet. The keyword var is where you type in the 
            //data type. You usually want to name the local variable besides the generic 
            //"item". The items in this case is called "car". You replace the word 
            //"collection" with the collection you want to work with/access. 
            //In this case its the cars collection.
            foreach (Car car in cars)
            {
                result += car.FormatDetailsForDisplay();
            }

            //When working with collections it is easier to use foreach than a for statement.
            //Use the for statement with arrays.


            resultLabel.Text = result;
        }
    }
}