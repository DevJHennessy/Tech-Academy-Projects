using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FizzBuzz
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    resultLabel.Text += "FizzBuzz<br />";

                }
                else if (i % 3 == 0 && i % 5 != 0)
                {
                    resultLabel.Text += "Fizz <br />";

                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    resultLabel.Text += "Buzz <br />";

                }
                else
                {
                    resultLabel.Text += i.ToString() + "<br />";
                }
            }
        }
    }
}