using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_19_OperatorOverloading
{
    class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            //Adds the first/top card to the hand:
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            //Removes the added card from the deck:
            //This removes that card at index 0, which is the first/top card.
            Deck.Cards.RemoveAt(0);

        }
    }
}
