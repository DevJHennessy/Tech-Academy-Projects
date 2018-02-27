using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_054_Switch
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //A switch statement is similar to an if statement. It's constrol of flow
            //experession. It's a statement that selects a given switch to execute,
            //based on a list of candidates. It's like a train switch, where the train
            //comes to a fork in the road and the switch will switch between different
            //available options to control the train's flow.
            //Why would you choose an switch statement over an if statement?
            //It's a little more flexible. It works great with enums.

            /*
            string result = "";
            int switchExpression = 4;

            //the switch statement code snippet is sw tab tab:
            switch (switchExpression)
            {
                case 0:
                //A switch section can have more than one case.
                case 1:
                    result += "Case 0 or 1<br />";
                    break;
                    //The break will pop you out of the switch and continue on with
                    //the rest of the logic in your code. You can also use return,
                    //which will pop you out of everything, including the method.
                case 2:
                    result += "Case 2<br />";
                    break;
                //If of the other labels don't catch the switch, then it will
                //fall out to the default, which will catch any value that comes
                //through. The Default is optional.
                case 3:
                    result += "Case 3<br />";
                //Instead of break or return you can use the goto and provide a 
                //case to make the switch evaluate that switch instead. This
                //will make switches show in the result label.
                    goto case 1;
                //return;
                //result += "Unreachable"; //Unreachable code after return.
                //You can do simple expressions, as shown:
                case 8 - 4:
                    result += "Case 4<br />";
                    break;
                case 5:
                    result += "Case 5<br />";
                    //The last thing you can do to break out of the switch is a throw:
                    throw new Exception();
                default:
                    result += "Default <br />";
                    break;
            }
            */


            //Using switches with enumerations:

            var hero = new Character();
            hero.Name = "Elric";
            hero.Type = CharacterType.Fighter;


            string result = "";
            switch (hero.Type)
            {
                case CharacterType.Wizard:
                    result += "Wizard";
                    break;
                case CharacterType.Fighter:
                    result += "Fighter";
                    break;
                case CharacterType.Monster:
                    result += "Monster";
                    break;
                default:
                    break;
            }

            resultLabel.Text = result;
        }
    }

    public class Character
    {
        public string Name { get; set; }
        public CharacterType Type { get; set; }
    }

    public enum CharacterType
    {
        Wizard,
        Fighter,
        Monster
    }
}