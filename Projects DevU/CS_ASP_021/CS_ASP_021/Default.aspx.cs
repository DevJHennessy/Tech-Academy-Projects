using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_021
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            /* How to make a new string array with 5 elements:
            string[] values = new string[5];
            values[0] = TextBox1.Text;
            values[1] = TextBox1.Text;
            values[2] = TextBox3.Text;
            values[3] = TextBox4.Text;
            values[4] = TextBox5.Text;
            */

            //To return the value of element 3 at index 2:
            //resultLabel.Text = values[2];

            //How to find out how many elements are in the array:
            //resultLabel.Text = values.Length.ToString();

            //How to initalize array at the time you delcare it:
            string[] values = new string[5] { "Bob", "Steve", "Chuck", "Melony", "Amy" };
            ViewState.Add("MyValues", values);
            resultLabel.Text = "Values added . . . ";
        }

        protected void retrieveButton_Click(object sender, EventArgs e)
        {
            string[] values = (string[])ViewState["MyValues"];
            TextBox1.Text = values[0];
            TextBox2.Text = values[1];
            TextBox3.Text = values[2];
            TextBox4.Text = values[3];
            TextBox5.Text = values[4];
            resultLabel.Text = "Values retreived . . . ";
        }
    }
}