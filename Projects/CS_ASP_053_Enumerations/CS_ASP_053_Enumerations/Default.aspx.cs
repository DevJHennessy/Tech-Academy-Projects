using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_053_Enumerations
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //The strings below are sometimes referred to as magic strings, and you
            //should not rely on evaluation of magic strings because you will
            //frequently find that the data is bad. That whether the data entry was
            //fat-fingered or it's outside the boundary of what you'd expect the
            //input to be. This is where constraints are good.
            //var hero = new Character();
            //hero.Name = "Elric";
            //hero.Type = "Fghter"; //Fat-fingered, missing i will give error.
            //This can be fixed with a special class, enum.

            //This code will evaluate the type and will perform some logic in the code
            //based on the hero's type.
            //if (hero.Type == "Fighter")
            //{
            //    resultLabel.Text = "Our hero is a fighter!";
            //}

            //Using the enum:
            var hero = new Character();
            hero.Name = "Elric";
            hero.Type = CharacterType.Fighter;
            //If you mistype Fighter as Fghter, you'll get a compilation error
            //instead of a runtime error, which is much easier to find and fix.
            //hero.Type = CharacterType.Fghter; Fghter here is underlined in red.


            if (hero.Type == CharacterType.Fighter)
            {
                resultLabel.Text = "Our hero is a fighter!";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var hero = new Character();
            //A user can type in their own hero name:
            hero.Name = heroNameTextBox.Text;

            CharacterType selection;
            if (Enum.TryParse(heroTypeDropDownList.SelectedValue, out selection))
            {
                hero.Type = selection;
            }

            if (hero.Type == CharacterType.Fighter)
            {
                resultLabel.Text = "You selected a fighter!";
            }
        }

    }

    public class Character
    {
        public string Name { get; set; }
        //The Type here is a RPG class in a game, such a Thief, Wizard, Druid, etc.
        //public string Type { get; set; }
        //The data type is changed from string to CharacterType:
        //Often the name of the enumeration is the same as the property name.
        public CharacterType Type { get; set; }
        //example of the data type name being the same as the property name.
        //public CharacterType CharacterType { get; set; }

    }

    //The enum has the enum keyword, unlike the class and the class keyword.
    //The value inside the enum are the only values that can be used, so you couldn't
    //even evaluate Fghter, only Fighter.
    public enum CharacterType
    {
        Wizard,
        Fighter,
        Monster,
        HighWizard,
        Thief
    }
}