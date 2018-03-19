using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeroMonster;

namespace CS_ASP_041_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            resultLabel.Text += String.Format("\r\nName: {0} - Health: {1} - DamageMaximum: {2} - AttackBonus: {3}", character.Name, character.Health, character.DamageMaximum.ToString(), character.AttackBonus.ToString());
        }
    }
}
