﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_11_Methods
{
    class Card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }

        public Card()
        {
            Suit = "Spades";
            Rank = "Two";
        }
    }
}
