using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_6_XmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";

            int max = 0;
            int min = 0;


            for (int i = 0; i < names.Length; i++)
            {
                //Is this the largest/max number so far?
                if (numbers[i] > numbers[max])
                {
                    max = i;
                }
                //Is this the smallest count so far?
                if (numbers[i] < numbers[min])
                {
                    min = i;
                }

               
            }

            result = String.Format("Most battles belong to: {0} (Value: {1})", names[max], numbers[max]);
            result += String.Format("<br>Fewest battles belong to: {0}(Value: {1})", names[min], numbers[min]);
            resultLabel.Text = result;
        }
    }
}