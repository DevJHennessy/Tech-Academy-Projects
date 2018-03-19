using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_23
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                double[] hours = new double[0];

                ViewState.Add("Hours", hours);
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            double[] hours = (double[])ViewState["Hours"];

            //Since arrays are immutable, to resize ASP.NET copies the old one and puts it in a new, larger(or smaller?) array.
            Array.Resize(ref hours, hours.Length + 1);

            //Get back the highest index in a given dimension, which is indicated by the (0):
            int newestItem = hours.GetUpperBound(0);

            hours[newestItem] = double.Parse(hoursTextBox.Text);


            ViewState["Hours"] = hours;

            resultLabel.Text = String.Format("Total hours: {0}" +
                "<br>Most Hours: {1}" +
                "<br>Least Hours: {2}" +
                "<br>Average Hours: {3:N2}", hours.Sum(), hours.Max(), hours.Min(), hours.Average());
        }
    }
}