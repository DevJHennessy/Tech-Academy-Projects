using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_047
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            //Without the overloaded constructor, this code is broken.
            /*
            Car car1 = new Car("BMW", "528i", 2010, "Black");
            Car car2 = new Car("BMW", "745li", 2005, "Black");
            Car car3 = new Car("Ford", "Escape", 2008, "White");
            */
      
            List<Car> cars = new List<Car>();

            //It's always a good idea to inialize a new instance of a given type with its
            //values, to set it into its initial state, but now Car class doesn't have any.
            //This is where Object Initializers come in.
            //You end up combining Car car1 = new Car("BMW", "528i", 2010, "Black"); with
            //cars.Add(car1); Like so:

            //Rule of thumb: The property values don't have to go in order, but it's considered
            //A best practice to do so. Shown below is out of order so that you can see the
            //code still works.
            cars.Add(new Car { Make = "BMW", Model = "528i", Color = "Black", Year = 2010 });
            cars.Add(new Car { Make = "BMW", Model = "745li", Year = 2005, Color = "Black" });
            cars.Add(new Car { Make = "Ford", Model = "Escape", Color = "White", Year = 2008 });

            for (int i = 0; i < cars.Count; i++)
            {
                //ElementAt is one way to get at a single member of the collection.
                //There is another, more elegeant way to get to individual instances in an
                //iteration statement.
                result += cars.ElementAt(i).FormatDetailsForDisplay();
            }

            /*
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            */

            resultLabel.Text = result;
        }
    }
}