using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino;
using Casino.TwentyOne;
using System.IO;

namespace CS_28_Libraries
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";
            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();

            bool validAmswer = false;
            int bank = 0;
            while (!validAmswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAmswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAmswer) 
                {
                    Console.WriteLine("Please enter whole digits only.");
                }

            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Student\Logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();

                    }
                    //Execeptions are caught from most specific to most generic:
                    catch (FraudException)
                    {
                        Console.WriteLine("Security! This person is trying to cheat! Kick this person out!");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("An error has occured. Please contact your System Administrator.");
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }
    }
}
