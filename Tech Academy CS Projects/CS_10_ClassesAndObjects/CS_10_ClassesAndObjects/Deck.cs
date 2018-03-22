using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_10_ClassesAndObjects
{
    public class Deck
    {
        public Deck()
        {

            Cards = new List<Card>();
            
            //Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Spades", "Clubs", "Diamonds", "Hearts" };
            List<string> Ranks = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
            foreach (var rank in Ranks)
            {
                foreach (var suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Rank = rank;
                    Cards.Add(card);
                }
            }
            
        }
        public List<Card> Cards { get; set; }

    }
}
