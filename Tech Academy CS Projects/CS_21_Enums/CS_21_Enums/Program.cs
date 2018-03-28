using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_21_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Assinging a variable an enum property:
            //DaysOfTheWeek day = DaysOfTheWeek.Saturday;
            ////ConsoleColor is a built-in enum type:
            //ConsoleColor color = ConsoleColor.DarkCyan;

            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int underlyingValue = (int)Suit.Diamonds;
            //Console.WriteLine(underlyingValue);

            Deck deck = new Deck();
            deck.Shuffle(5);

            foreach (var card in deck.Cards)
            {
                Console.WriteLine(card.Rank + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        //public enum DaysOfTheWeek
        //{
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}
    }
}
