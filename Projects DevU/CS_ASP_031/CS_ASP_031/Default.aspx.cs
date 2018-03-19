using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_031
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int heroHealth = 100;
            int monsterHealth = 100;

            displayBattleHeader();

            // Hero gets bonus first attack
            monsterHealth = performAttack(monsterHealth, 20, "Hero", "Monster");

            while (heroHealth > 0 && monsterHealth > 0)
            {
                displayRoundHeader();

                // Perform battle here!
                heroHealth = performAttack(heroHealth, 20, "Monster", "Hero");
                monsterHealth = performAttack(monsterHealth, 20, "Hero", "Monster");

                //displayMonsterStats();


            }

            displayResult(heroHealth, monsterHealth);

        }


        private void displayBattleHeader()
        {
            resultLabel.Text += "<h3>Battle Between the Hero (you) and the Monster (bad guy)</h3>";
        }

        private void displayRoundHeader()
        {
            resultLabel.Text += "<hr /><p>Round begins ...</p>";
        }

        private int performAttack(int defenderHealth, int attackerDamageMax, string attackerName, string defenderName)
        {
            Random random = new Random();
            int damage = random.Next(1, attackerDamageMax);
            defenderHealth -= damage;

            describeRound(attackerName, defenderName, defenderHealth);
            return defenderHealth;
        }

        private void describeRound(string attackerName, string defenderName, int defenderHealth)
        {
            if (defenderHealth <= 0)
                resultLabel.Text += String.Format("<br />{0} attacks {1} and vanquishes the {2}.", attackerName, defenderName, defenderName);
            else
                resultLabel.Text += String.Format("<br />{0} attacks {1}, leaving {2} with {3} health.", attackerName, defenderName, defenderName, defenderHealth);
        }

        private void displayResult(int heroHealth, int monsterHealth)
        {
            if (heroHealth <= 0)
                resultLabel.Text += "<h3>Monster wins!</h3>";
            else if (monsterHealth <= 0)
                resultLabel.Text += "<h3>Hero wins!</h3>";
            else
                resultLabel.Text += "<h3>They are both losers!</h3>";
        }
        /* The three below methods are overloaded methods. Each method that shares the same name
         * must have a different method signature. A method signature is basically the number of input parameters
         * and their datatypes. The first one has 4 input parameters, the second 3, 
         * and the last only has two in this example. You cannot have overloaded methods with the exact
         * same number of parameters and datatypes.
         */

        //Renamed from displayFullStatsOfTheMonster(
        public void displayMonsterStats(
            string monsterName, 
            int health, 
            int damageMaximum, 
            double criticalHitChance)
        {
            resultLabel.Text += String.Format("<p>{0} Current Stats<br />Health: {1}<br />Damage Max: {2}<br />Critical Hit Chance: {3:P}</p>", monsterName, health, damageMaximum, criticalHitChance);
        }

        //Rename from displayMonstersPartialStats
        public void displayMonsterStats(
            string monsterName, 
            int health, 
            int damageMaximum)
        {
            resultLabel.Text += String.Format("<p>{0} Current Stats<br />Health: {1}<br />Damage Max: {2}</p>", monsterName, health, damageMaximum);
        }

        //Rename from displayMonstersNameAndHealth, also changed from being a void to a string.
        public string displayMonsterStats(
            string monsterName, 
            int health)
        {
            //
            //resultLabel.Text += String.Format("<p>{0} Current Stats<br />Health: {1}</p>", monsterName, health);
            return String.Format("<p>{0} Current Stats<br />Health: {1}</p>", monsterName, health);

        }

        /* Even though this returns a different value than the method above (string vs. void), you still
         * cannot use it because they use the same method signature.
        public void displayMonsterStats(
     string name,
     int damageMaximum) {}
     */
      

    }
}