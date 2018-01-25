using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_018
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // A lesson to learn how to debug code.
            myTextBox.Text = 500.ToString();
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (firstCalendar.SelectedDate.AddDays(15) >= secondCalendar.SelectedDate)
            {
                TimeSpan elapsedDays = firstCalendar.SelectedDate.Subtract(secondCalendar.SelectedDate);
                double userValue = double.Parse(myTextBox.Text);
                double days = elapsedDays.TotalDays;
                double sum = userValue * days + 100;
                resultLabel.Text = sum.ToString();
            }
            else
            {
                resultLabel.Text = "Error. You must choose a date at least 14 days apart.";
            }
        }
    }
}