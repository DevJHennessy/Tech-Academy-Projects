﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_23_LambdaExpressions
{
    class Deck
    {
        public Deck()
        {

            Cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Rank = (Rank)i;
                    card.Suit = (Suit)j;
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
