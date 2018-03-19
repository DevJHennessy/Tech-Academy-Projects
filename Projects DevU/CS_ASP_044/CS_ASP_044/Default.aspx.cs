using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_044
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Class names should be PascalCase as shown:
            Hero hero = new Hero("Baltek", 105);


            //Locally-scoped variables have camelCase, as shown below:
            int damageInflictedOnMonster = 5;

            Battle battle = new Battle();

            if (damageInflictedOnMonster > 10)
                resultLabel.Text = "A fatal blow!";


        }

        private void formatResults(Hero hero)
        {
            // Stuff
        }
    }
}