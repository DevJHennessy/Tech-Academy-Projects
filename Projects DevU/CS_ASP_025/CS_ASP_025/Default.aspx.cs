using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_025
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            //This is nested three lines deep. Code it harder to follow when written this way.
            /*
            if (firstCheckBox.Checked)
            {
                if (secondCheckBox.Checked)
                {
                    if (thirdCheckBox.Checked)
                    {
                        resultLabel.Text = "They're all checked!";
                    }
                }
            }
            */

            //This does the same thing but without nesting and is much easier to read:
            //The return key shoots you back out of the method.
            //These are called gated if statements, because they are closed/opened.
            //If you walk through all the gates, you can perform the code at the end.
            /*
            if (!firstCheckBox.Checked) return;
            if (!secondCheckBox.Checked) return;
            if (!thirdCheckBox.Checked) return;
            resultLabel.Text = "They're all checked!";
            */

            //Remember that && means AND.
            if (firstCheckBox.Checked && 
                secondCheckBox.Checked && 
                thirdCheckBox.Checked)
                resultLabel.Text = "They're all checked!";
        }
    }
}