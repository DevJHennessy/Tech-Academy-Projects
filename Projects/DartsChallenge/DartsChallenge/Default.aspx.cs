using Darts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DartsChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //This creates a new Game instance with a player 1 and player 2:
            Game game = new Game("Player 1", "Player 2");
            //Play the game:
            string result = game.Play();
            //Show the results in the resultLabel:
            resultLabel.Text = result;

        }
    }
}