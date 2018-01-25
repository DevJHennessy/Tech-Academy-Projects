using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_4_EpicSpies
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Setting the dates on the calendar
                previousCalendar.SelectedDate = DateTime.Now.Date;
                startCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                endCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
                endCalendar.VisibleDate = DateTime.Now.Date.AddDays(21);
            }
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            // Spies charge $500.00 a day for work

            TimeSpan lengthofassignment = endCalendar.SelectedDate.Subtract(startCalendar.SelectedDate);
            double totalcost = lengthofassignment.TotalDays * 500;


            // If Assignment is greater than three weeks, spy gets a $1,000 bonus for all the hard work

            if (lengthofassignment.TotalDays > 21)
            {
                totalcost += 1000;
            }


            string result = String.Format("Assignment of {0} to assignment {1} is authorized." +
            "<br>Budget total: {2:C}", codeNameTextBox.Text, assignmentTextBox.Text, totalcost);


            resultLabel.Text = result;

            // Spies must get at least two weeks off between asignments, otherwise they nix their emplorers.

            TimeSpan vacation = startCalendar.SelectedDate.Subtract(previousCalendar.SelectedDate);
            if (vacation.TotalDays < 14)
            {
                resultLabel.Text = "Error. Must allow at least two weeks between previous assignment and new assignment. A spy can't be overworked or they get trigger happy.";
                startCalendar.SelectedDate = previousCalendar.SelectedDate.AddDays(14);
                startCalendar.VisibleDate = previousCalendar.SelectedDate.AddDays(14);
                endCalendar.SelectedDate = previousCalendar.SelectedDate.AddDays(21);
                endCalendar.VisibleDate = previousCalendar.SelectedDate.AddDays(21);
            }
            
        }
    }
}