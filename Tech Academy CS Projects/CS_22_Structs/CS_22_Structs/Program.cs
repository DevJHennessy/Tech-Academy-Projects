using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_22_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Typically classes in C# are reference type
            //Any data type that stores data by reference is known as reference type.
            Card card1 = new Card();
            Card card2 = card1;
            card1.Rank = Rank.Eight;
            card2.Rank = Rank.King;
            Console.WriteLine(card1.Rank); //Displays King when Card was a class. When Card
            //is changed to a struct, the value now is Eight.

            //Value types are separate entities. They are not pointing to any values that
            //object has. Built in value types: int, bool, enums, datetype. So what is an
            //Integer if it's not a class? An int is a struct, not a class, like a String.
            //int is an alias for Int32. A strunct is nearly the same as a class, except that
            //it is a value type instead of a reference type. A struct cannot be inherited.
            //Value types cannot have a value of null. They must have some data. 

            //Deck deck = new Deck();
            //deck.Shuffle(5);

            //foreach (var card in deck.Cards)
            //{
            //    Console.WriteLine(card.Rank + " of " + card.Suit);
            //}

            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
