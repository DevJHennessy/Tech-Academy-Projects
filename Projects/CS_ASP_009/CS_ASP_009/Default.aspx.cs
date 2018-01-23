using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_009
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //int i = 1;
            //int j = 2;
            //int result = i + j;
            //int result = i - j;
            //int result = i * j;
            //int result = i / j;

            //This is called addition assignment:
            /*
            i = i + 5;
            i += 5;
            i++;
            i--;
            */

            /*
            int myInterger = 5 + 1 * 7;
            resultLabel.Text = myInterger.ToString();
            */

            //double myDouble = 5.5;
            //int myInteger = 7;
            //int myOtherInterger = 4;

            //double myResult = myDouble + myInteger;
            //int myResult = (int)myDouble + myInteger;
            //resultLabel.Text = myResult.ToString();

            //You lose the .5 trying to cast from double to integer, meaning you lose precision.
            //int myResult = myInteger / myOtherInterger;


            //double myResult = (double)myInteger / (double)myOtherInterger;
            //resultLabel.Text = myResult.ToString();
            //This ensures you get the decimal precision.

            /*
            int firstNumber = 2000000000;
            int secondNumber = 2000000000;
            int resultNumber = firstNumber * secondNumber;

            resultLabel.Text = resultNumber.ToString();
            /* This shows a negative number because of overflow.
            This means, because both were near the max for the data type, that
            when they were multiplied they overflowed.
            */

            int first = 5;
            int second = 2;
            double result = (double)first / (double)second;
            resultLabel.Text = result.ToString();





        }
    }
}