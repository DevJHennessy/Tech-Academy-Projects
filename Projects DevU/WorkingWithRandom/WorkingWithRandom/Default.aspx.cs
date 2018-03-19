using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithRandom
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            int Score;
            bool IsDouble;
            bool IsTriple;
            Random _random = new Random();

            Score = _random.Next(0, 21);

            int multiplier = _random.Next(1, 101);
            if (multiplier > 95) IsTriple = true;
            else if (multiplier > 90) IsDouble = true;

            string result = multiplier.ToString();
            resultLabel.Text = result;
            */


            string result = "";
            //int multiplier = 0;
            Random _random = new Random();
            int Score;
            bool IsDouble = false;
            bool IsTriple = false;

            for (int ctr = 1; ctr <= 20; ctr++)
            {
                // Zero (0) is the Bullseye
                Score = _random.Next(0, 21);

                int multiplier = _random.Next(1, 101);
                if (multiplier > 95) IsTriple = true;
                else if (multiplier > 90) IsDouble = true;

                //if (IsTriple) Score *= 3;
                //else if (IsDouble) Score *= 2;
                //else Score *= 1;

                //Inner and Outer Bullseye:
                //You have a 5% chance to get IsTriple
                if (IsTriple && Score == 0) Score = 50;
                else if (Score == 0) Score = 25;

                result += "<br />" + Score;
            }
            resultLabel.Text = result;

            //resultLabel.Text = Score.ToString();


            //for (int ctr = 1; ctr <= 20; ctr++)
            //{
            //    result += "<br />" + _random.Next(1, 101);

            //}
            //resultLabel.Text = result;






        }
    }
}