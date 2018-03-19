using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMonster
{
    //Added public here:
    public class Character
    {

        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack(Dice dice)
        {
            dice.Sides = this.DamageMaximum;
            return dice.Roll();
        }

        public void HitForLoss(int damage)
        {
            this.Health -= damage;
        }
    }

    //Added public here:
    public class Dice
    {
        Random random = new Random();

        public int Sides { get; set; }

        public int Roll()
        {
            return random.Next(this.Sides);
        }
    }
}
