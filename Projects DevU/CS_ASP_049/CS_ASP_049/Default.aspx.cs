using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_049
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            //The Dictionary Collection is similar to the List Collection except that you 
            //create a key, which is used to access a given member of that collection.
            //Like a regular dictionary, where you have a word(keyword) and the definition of
            //that word, you have a key and then the larger value that's associated with it.
            //Usually you use a string or integer as the key, and type will be specific
            //instance of a class. Think of the key that is anything meaningful inside your
            //system as long as it is unique. For instance, if you're working with cars, 
            //you might make the key the vin (vehicle identification number) and the value
            //the object of type Car that stores the properties (Make, Model, Color, Year).

            //Dictionary type has two generic values Tkey (datatype of key),
            //Tvalue (datatype of values) and this often called name-value pairs:

            //Dictionary Collection example with Object Initializers:
            /*
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            cars.Add("V1", new Car { Make = "BMW", Model = "528i", Year = 2010, Color = "Black" });
            cars.Add("V2", new Car { Make = "BMW", Model = "745li", Year = 2005, Color = "Black" });
            cars.Add("V3", new Car { Make = "Ford", Model = "Escape", Year = 2008, Color = "White" });
            */

            //Dictionary Collection example with Collection Initializer:
            Dictionary<string, Car> cars = new Dictionary<string, Car>() {
                { "V1", new Car { Make = "BMW", Model = "528i", Year = 2010, Color = "Black" } },
                { "V2", new Car { Make = "BMW", Model = "745li", Year = 2005, Color = "Black" } },
                { "V3", new Car { Make = "Ford", Model = "Escape", Year = 2008, Color = "White" } }
        };
            /* Accessing an item at a given element:
            for (int i = 0; i < cars.Count; i++)
            {
                result += "<h2>" + cars.ElementAt(i).Key + "</h2>"
                    + cars.ElementAt(i).Value.FormatDetailsForDisplay();
            }
            */

            /*
            //How to use the key to access a given item out of the collection:
            Car v2;
            if (cars.TryGetValue("V2", out v2))
                result += v2.FormatDetailsForDisplay();
            */

            //How to remove an item from a collection:
            if (cars.Remove("V1"))
                result += "Successfully removed V1!<br />";

            for (int i = 0; i < cars.Count; i++)
            {
                result += "<h2>" + cars.ElementAt(i).Key + "</h2>"
                    + cars.ElementAt(i).Value.FormatDetailsForDisplay();
            }


            resultLabel.Text = result;
        }
    }
}