using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_038
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Car myCar = new Car();
            //This is a shortcut for this:
            //Car myCar;
            //myCar = new Car();

            Car myOtherCar = myCar;

            //This is generally considered a best practice:
            myCar = null;
            //The null keyword means indeterminate, it doesn't mean nothing, 
            //only that you are removing any of the values and you don't know 
            //what my car is set to.

            myOtherCar = null;
            //The next time the garbage collector comes by, it will see that the 
            //reference count has now gone to zero and remove the Car() object 
            //that was created in the computer's memory with the new keyword.

        }
    }
}