using HeroMonster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_041
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //In order to use the character class, you have to create a reference to the 
            //assembly. Right click on the references in the solution explorer and add 
            //new reference. Since the Character class was added in the HeroMonster, you
            //can navigate in the project solution and add HeroMonster. Not the Character
            //class is able to be used. At this point Character is still unusable, so you 
            //have to add public in front of each class in the namespace HeroMonster.

            Character hero = new Character();

            hero.Name = "The Mighty Steelheart";
            hero.Health = 100;
            hero.DamageMaximum = 25;
            hero.AttackBonus = false;

            Character monster = new Character();

            monster.Name = "The Vile Squasher";
            monster.Health = 100;
            monster.DamageMaximum = 22;
            monster.AttackBonus = true;


            Dice dice = new Dice();

            //Bonus attack:
            if (hero.AttackBonus)
            {
                monster.HitForLoss(hero.Attack(dice));
            }
            if (monster.AttackBonus)
            {
                hero.HitForLoss(monster.Attack(dice));
            }

            while (hero.Health > 0 && monster.Health > 0)
            {

                monster.HitForLoss(hero.Attack(dice));
                hero.HitForLoss(monster.Attack(dice));

                showHealth(hero);
                showHealth(monster);

            }

            displayResult(hero, monster);

        }


        private void displayResult(Character opponent1, Character opponent2)
        {
            if (opponent1.Health <= 0 && opponent2.Health <= 0)
                resultLabel.Text += String.Format("\r\n{0} and {1} slew each other. They are both losers!", opponent1.Name, opponent2.Name);
            else if (opponent2.Health <= 0)
                resultLabel.Text += String.Format("\r\n{0} has been slain. {1} wins!", opponent2.Name, opponent1.Name);
            else
                resultLabel.Text += String.Format("\r\n{0} has been slain. {1} wins!", opponent1.Name, opponent2.Name);
        }


        private void showHealth(Character character)
        {
            resultLabel.Text += String.Format("<p>Name: {0} - Health: {1} - DamageMaximum: {2} - AttackBonus: {3}</p>", character.Name, character.Health, character.DamageMaximum.ToString(), character.AttackBonus.ToString());
        }
    }
}
