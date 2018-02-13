using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_048
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";


            //This object initializer is a combination of
            //Car car1 = new Car("BMW", "528i", 2010, "Black"); and cars.Add(car1);
            //Object Initializer:
            //cars.Add(new Car { Make = "BMW", Model = "528i", Color = "Black", Year = 2010 });

            //The Object Initializer can be refactored in one step, basically putting it 
            //in one line from three:
            //This is a Collection Initializer:
            List<Car> cars = new List<Car>()
            {
                new Car { Make = "BMW", Model = "528i", Color = "Black", Year = 2010},
                new Car { Make = "BMW", Model = "745li", Color = "Black", Year = 2005},
                new Car { Make = "Ford", Model = "Escape", Color = "White", Year = 2008}

            };

            //What's the benefit of doing a Collection Initializer over Object Initializer?
            //You're putting the collection into a valid state all in one shot. You never
            //have an empty list of cars, you immediately have a list of cars with actual
            //car instances inside of it.

            for (int i = 0; i < cars.Count; i++)
            {
                result += cars.ElementAt(i).FormatDetailsForDisplay();
            }


            resultLabel.Text = result;

        }
    }
}