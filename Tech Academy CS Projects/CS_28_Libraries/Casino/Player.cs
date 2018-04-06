using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player
    {
        private List<Card> _hand = new List<Card>();

        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid Id { get; set; }

        //Constructor chaining:
        public Player(string name) : this(name, 100)
        {
            //You don't need any implementation here because it inherits from the other 
            //Player constructor.
        }

        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }

        public bool Bet(int betAmount)
        {
            if (Balance - betAmount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that high.");
                return false;
            }
            else
            {
                Balance -= betAmount;
                return true;
            }
        }

        //Overloaded operator method:
        //Game is the return type.
        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }

        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
