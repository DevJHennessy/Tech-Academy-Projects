using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_14_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ////The TwentyOneGame class is calling from the superclass Game.
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Bob", "Louise", "Linda", "Gene", "Tina" };
            //game.ListPlayers();
            //Console.ReadLine();

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
