using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_11_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            //deck = Shuffle(deck);
            //deck = Shuffle(deck, 5); //Shuffling deck 5 times.
            //deck = Shuffle(deck, 3); //Shuffling with optional parameter.

            //With out parameter:
            int timesShuffled = 0; //The out parameter is being assigned here.
            deck = Shuffle(deck, out timesShuffled, 20);


            //Can make named parameters, which does the same thing but may be easier
            //to read:
            //deck = Shuffle(deck: deck, times: 3);

            foreach (var card in deck.Cards)
            {
                Console.WriteLine(card.Rank + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled: {0}", timesShuffled);
            Console.ReadLine();
        }

        //When you assign a parameter a default value it creates an optional parameter.
        //Putting in an out parameter.
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {

                timesShuffled++;
                List<Card> TempList = new List<Card>();

                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            return deck;
        }

        //Overload method to shuffle multiple times.
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
