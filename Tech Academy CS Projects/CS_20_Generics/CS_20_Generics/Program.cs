using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_20_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player now has a generic Card, and if you were making another type of game, say
            //Roulette, you would put in a Card, but a different generic type, because there
            //are no cards in Roulette.
            Player<Card> player = new Player<Card>();
            player.Hand = new List<Card>();
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
