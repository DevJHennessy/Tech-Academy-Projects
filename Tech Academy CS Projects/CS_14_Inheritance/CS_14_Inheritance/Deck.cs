using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_14_Inheritance
{
    class Deck
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

        //When you assign a parameter a default value it creates an optional parameter.
        //Putting in an out parameter.
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {

                List<Card> TempList = new List<Card>();

                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                this.Cards = TempList;
            }
        }
    }
}
