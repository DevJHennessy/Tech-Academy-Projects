using Darts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DartsChallenge
{
    public class Score
    {
        //A static method that calculates the score for a dart throw:
        //The method must have a player and a dart:
        public static void ScoreTheDart(Player player, Dart dart)
        {
            //Need a variable to hold the score:
            int score = 0;

            //If IsTriple is True, then the score is assigned the dart.Score times three.
            if (dart.IsTriple)
                score = dart.Score * 3;
            else if (dart.IsDouble)
                score = dart.Score * 2;
            else score = dart.Score;

            //Logic for Bullseye:
            //Zero (0) is the bullseye, and IsTriple represents a five percent chance
            //both together represent the inner Bullseye. 0 alone is the outer Bullseye.
            if (dart.Score == 0 && dart.IsTriple) score = 50;
            else if (dart.Score == 0) score = 25;

            //Have to set the player's score to the local score variable:
            player.Score += score;
        }
    }
}