using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            //Adds the first/top card to the hand:
            Hand.Add(Deck.Cards.First());
            //Logging everytime a card is dealt:
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            //Logging:
            using (StreamWriter file = new StreamWriter(@"C:\Users\Student\Logs\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card); 
            } //Once the code hits here the Garbage Collector gets rid of the above code.
            //That's what the using statement does. 
                Console.WriteLine(card);
            //Removes the added card from the deck:
            //This removes that card at index 0, which is the first/top card.
            Deck.Cards.RemoveAt(0);

        }
    }
}
