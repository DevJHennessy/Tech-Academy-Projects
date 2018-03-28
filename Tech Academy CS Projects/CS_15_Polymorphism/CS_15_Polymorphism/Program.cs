using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_15_Polymorphism
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

            //An example of polymorphism:
            //Game twentyOneGame = new TwentyOneGame();
            //Why would you want to do this?
            //If you had many different games and you wanted to make a list of all the games,
            //you can only choose one data type, and a List<Game> would allow you to add
            //all those games to a list:
            //List<Game> games = new List<Game>();
            //games.Add(twentyOneGame);
            //games.Add(pokerGame); //if this existed.
            //games.Add(kingsCornerGame); //if this existed.

            //Polymorphism:
            //It's the ability of a class to change into its inheriting class, and it gave
            //certain advantages.
        }
    }
}
