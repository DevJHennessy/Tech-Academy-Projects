using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_059_LocalDbExample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Connecting to a database:
            ACMEEntities db = new ACMEEntities();

            var customers = db.Customers;

            string result = "";

            /*
            foreach (var customer in customers)
            {
                result += "<p>" + customer.Name + "</p>";
            }
            */

            //To display grid view of data from database:
            //customersGridView.DataSource = customers; //This will produce an error for
            //the DataBind below.
            //The ToList will convert the result from the db query to a list of customers.
            customersGridView.DataSource = customers.ToList();
            customersGridView.DataBind();

            resultLabel.Text = result;
        }
    }
}