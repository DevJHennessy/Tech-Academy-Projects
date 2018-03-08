using Darts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DartsChallenge
{
    public class Game
    {
        //The Game has two players:
        Player _player1 = new Player();
        Player _player2 = new Player();

        //A random variable for later use:
        Random _random = new Random();

        //Passing a string for player1 and player2 will allow you to change the name of 
        //the players to whatever you want when you make a new Game. You won't be bound
        //to player1 and player2 as names.
        public Game(string player1Name, string player2Name)
        {
            //Setting the fields to be the parameters:
            _player1.Name = player1Name;

            _player2.Name = player2Name;
        }

        //Making a new method to play the game:

        public string Play()
        {
            //While the score of player1 and player2 is less than 300, continue to play
            //the game.
            while (_player1.Score < 300 && _player2.Score < 300)
            {
                //PlayRound executes the logic of the game:
                //You need a playRound for each player:
                playRound(_player1);
                playRound(_player2);
            }
            //Returning the results of the entire game.
            return displayResults();
        }

        private string displayResults()
        {
            //What do you need for the results?
            //Player1 and their score, player2 and their score, and at the end,
            //the player who won.
            string result = String.Format("{0}: {1} <br/> {2}: {3}",
                _player1.Name, _player1.Score, _player2.Name, _player2.Score);

            //Adding the winner: If player1's score is greater than player2's, the show
            //player1 name, else show player2 name:
            return result += "<br/>Winner: " +
                (_player1.Score > _player2.Score ? _player1.Name : _player2.Name);
        }

        //The round needs a player to score the dart.
        private void playRound(Player player)
        {
            //Each player throws three darts, 
            for (int i = 0; i < 3; i++)
            {
                //In order to throw a dart, you need an instance of a dart:
                Dart dart = new Dart(_random);
                //After you've created a dart, you throw it:
                dart.Throw();
                //Score the dart
                Score.ScoreTheDart(player, dart);

            }
        }
    }
}