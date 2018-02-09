using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_043
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //The Car() has the parentheses, the method invocation operators, because you
            //are calling a method at the point of instantiation whenever you use the new
            //keyword. This is called the default constructor. The method is added 
            //automatically for you.
            //Car myCar = new Car();

            //After creating the overloaded constructor and create a new instance of the 
            //Car, you will see the overloaded versions, one that doesn't have any input
            //parameters and one that takes four input parameters.
            Car myCar = new Car("Oldsmobile", "Cutlas Supreme", 1985, "Silver");

            //Below will output the values assigned in the constructor in the Car class.
            //Make: Undefined - Model: Undefined - Year: 1980 - Color: Undefined
            resultLabel.Text = myCar.FormatDetailsForDisplay();

            DateTime d = new DateTime()
        }
    }
}