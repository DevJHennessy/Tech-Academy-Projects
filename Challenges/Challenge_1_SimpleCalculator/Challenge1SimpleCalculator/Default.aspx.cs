using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string firstNumber = firstTextBox.Text;
            string secondNumber = secondTextBox.Text;
            int a = int.Parse(firstNumber);
            int b = int.Parse(secondNumber);
            int c = a + b;
            resultLabel.Text = c.ToString();
            
        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            string firstNumber = firstTextBox.Text;
            string secondNumber = secondTextBox.Text;
            int a = int.Parse(firstNumber);
            int b = int.Parse(secondNumber);
            int d = a - b;
            resultLabel.Text = d.ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            string firstNumber = firstTextBox.Text;
            string secondNumber = secondTextBox.Text;
            int a = int.Parse(firstNumber);
            int b = int.Parse(secondNumber);
            int f = a * b;
            resultLabel.Text = f.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            string firstNumber = firstTextBox.Text;
            string secondNumber = secondTextBox.Text;
            double a = double.Parse(firstNumber);
            double b = double.Parse(secondNumber);
            double g = a / b;
            resultLabel.Text = g.ToString();
        }
    }
}