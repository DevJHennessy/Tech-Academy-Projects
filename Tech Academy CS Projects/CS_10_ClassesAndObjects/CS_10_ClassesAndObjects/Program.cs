using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_10_ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Card cardOne = new Card();
            //cardOne.Rank = "Queen";
            //cardOne.Suit = "Spades";

            //Console.WriteLine(cardOne.Rank + " of " + cardOne.Suit);
            //Console.ReadLine();

            Deck deck = new Deck();

            foreach (var card in deck.Cards)
            {
                Console.WriteLine(card.Rank + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();

        }
    }
}
