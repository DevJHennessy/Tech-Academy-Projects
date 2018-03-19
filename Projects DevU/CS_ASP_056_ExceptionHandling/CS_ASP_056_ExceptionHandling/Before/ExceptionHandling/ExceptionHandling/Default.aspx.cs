using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ExceptionHandling.Domain;

namespace ExceptionHandling
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            string result = "";

            try
            {
                // Calculate percentage of wins:
                decimal wins = decimal.Parse(gamesWonTextBox.Text);
                decimal total = decimal.Parse(totalGamesTextBox.Text);
                decimal winningPercentage = wins / total;

                result = string.Format("Winning Percentage: {0:P}",
                    winningPercentage);
                
                    var monster = new Character() { Name = "Zerg", HitPoints = 0 };
                    var hero = new Character() { Name = "Buzz", HitPoints = 5 };
                    GameActions.Battle(hero, monster);
                    result += string.Format("{0} attacked {1} leaving him with {2} hit points.",
                        hero.Name,
                        monster.Name,
                        monster.HitPoints);
                
            }
            //catch (DivideByZeroException)
            //{
            //    result = "Please enter a value greater than zero for Total Games Played.";
            //}
            catch (ArgumentOutOfRangeException)
            {
                result = "Either the attacker or defender are already dead.";
            }
            
            catch (FormatException ex)
            {
                result = "Format exception.";
            }
            //The Exception is a catch-all and always goes last as it is the most generic.

            catch (Exception ex)
            {
                //Instead of hardcoding the except like below, you can get an instance of the
                //exception that was thrown and evaluate it.
                //result = "There was a problem, please try again.";
                //The message will show that the user tried to divide by zero.
                result = "There was a problem: " + ex.Message;

                //throw;
            }
            finally
            {
                //Perform cleanup here. You probably won't need this until
                //we start working with external resources like database
                //connections, network connections, file system manuplulation, etc.
                //Code here will be performed after the catch exception is caught, and
                //close down connections, loosen everything back up, so that they are free
                //to be used by other instances of the application and continue on with the
                //program.

            }


            resultLabel.Text = result;
        }
    }
}