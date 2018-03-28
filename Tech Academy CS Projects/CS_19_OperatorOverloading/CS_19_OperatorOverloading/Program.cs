using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_19_OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using overloaded operators to add players to the game.

            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Bob";
            game += player; //game = game + player;
            game -= player;

            Deck deck = new Deck();
            deck.Shuffle(5);

            foreach (var card in deck.Cards)
            {
                Console.WriteLine(card.Rank + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();


        }
    }
}
