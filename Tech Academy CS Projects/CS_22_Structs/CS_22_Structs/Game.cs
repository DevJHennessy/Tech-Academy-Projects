using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_22_Structs
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public virtual void ListPlayers()
        {
            foreach (var player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }

        public abstract void Play();
    }
}
