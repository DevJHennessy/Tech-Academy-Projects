using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_23_LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();

            //One way to find how many Aces are still in the deck.
            int counter = 0;
            foreach (Card card in deck.Cards)
            {
                if (card.Rank == Rank.Ace)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);

            //How you write the same thing with a Lambda function:
            //x represents each element in the list. You can name the variable anything
            //but x is standard.
            int count = deck.Cards.Count(x => x.Rank == Rank.Ace);
            Console.WriteLine(count);

            List<Card> newList = deck.Cards.Where(x => x.Rank == Rank.King).ToList();

            foreach (var card in newList)
            {
                Console.WriteLine(card.Rank);

            }

            List<int> numberList = new List<int>() { 20, 4, 9, 15, 89, 777 };
            int sum = numberList.Sum();
            int sum2 = numberList.Sum(x => x + 5); //Adding 5 to each element value. Sum2 
            //should be 30 higher than sum.
            int sum3 = numberList.Max(); //Shows the highest value in the list.
            int sum4 = numberList.Min(); //Shows the smallest number in the list.
            //You can concatenate methods (method chaining):
            int sum5 = numberList.Where(x => x > 20).Sum();


            Console.WriteLine(sum5);

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
