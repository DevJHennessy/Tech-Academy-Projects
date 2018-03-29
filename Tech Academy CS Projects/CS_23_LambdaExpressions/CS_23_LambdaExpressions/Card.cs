﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_23_LambdaExpressions
{
    public struct Card
    {
        //The data type is now Suit.
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

    }

    public enum Suit
    {
        Clubs, //Underlying value = int 0.
        Diamonds, //Underlying value = int 1.
        Hearts, //Underlying value = int 2.
        Spades //Underlying value = int 3.
    }

    public enum Rank
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
