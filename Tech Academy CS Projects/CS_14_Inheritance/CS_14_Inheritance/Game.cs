﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_14_Inheritance
{
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public virtual void ListPlayers()
        {
            foreach (var player in Players)
            {
                Console.WriteLine(player);
            }
        }

        public abstract void Play();
    }
}
