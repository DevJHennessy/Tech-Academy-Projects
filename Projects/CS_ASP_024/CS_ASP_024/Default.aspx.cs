using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_024
{
    public partial class Default : System.Web.UI.Page
    {
        //This lesson is about Variable Scope.
        //Declaring z outside all the other code blocks makes it 
        //accessible to all other code blocks inside this outer code block.
        string z = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            z = "Hello ";
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            int x = 1;

            z += "Bob ";

            if (x==1)
            {
                x = 2;
                //int y = 3;
                z += "Tabor ";
            }

            string result = x.ToString();
            //Cannot use a variable that was declared inside a lower 
            //code block, the variable will not exist in the same context:
            //string result = y.ToString();
        }
    }
}