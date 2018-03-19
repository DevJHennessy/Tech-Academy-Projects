using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_051
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

            //Implicitly typed local variables using the "var" keyword. Whenever you're
            //working with local variables, variables that you define inside the scope of a
            //method, you actually don't have to give the compilier the datatype because it
            //can figure out the datatype based on the values, such as int hitPoints = 0;
            //The compilier can figure out that the datatype is integer based on the value 0.
            //So it is basically equivilent to typing: var hitPoints = 0;
            //Same thing with string: string heroName = "Pentagorn"; is the same as
            //var heroName = "Pentagorn"; This works with classes as well.
            //Instead of typing List<Car> cars =, as typed above, you could write var cars =.

            //To use the var keyword, the variable has to be initialized. For example:
            //var heroName; is invalid because the compilier has no clues to work with to
            //figure out the datatype. It would have to be: var heroName = "Pentagorn" or 
            //something like that to make sense. This is the first rule of working with
            //the keyword var. The second rule is that now the variable is permanently set
            //to that datatype. It can't be changed to some datatype in the future.

            //So why would you want to use the var keyword over declaring the datatype?
            //As your code becomes more complex, especially when using LINQ, the var keyword
            //will become increasingly important because it's difficult to determine the
            //datatype ahead of time, or the datatype is unknown, or the datatype will be
            //generated automatically at runtime. 

            foreach (Car car in cars)
            {
                result += car.FormatDetailsForDisplay();
            }

            resultLabel.Text = result;
        }
    }
}