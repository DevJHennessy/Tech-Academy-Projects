using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        //These properties are used to determine the score, and if the score is in
        //the double or triple ring.
        public int Score { get; set; }
        public bool IsDouble { get; set; }
        public bool IsTriple { get; set; }

        //Private field for random
        private Random _random;

        //The dart will always have an instance the Random class.
        public Dart(Random random)
        {
            _random = random;
        }

        public void Throw()
        {
            //When you throw the dart, it will randomly land on the bullseye, represented
            //by 0 or a wedge 1-20.
            Score = _random.Next(0, 21);

            //The multiplier is set to a random number of 1-100 because it is easy to
            //get percentages with 100. Anything above 95 represents a 5% chance.
            int multiplier = _random.Next(1, 101);
            //There is a five percent chance to get a triple score.
            if (multiplier > 95) IsTriple = true;
            //There is a five percent chance to get a double score.
            else if (multiplier > 90) IsDouble = true;
            
        }
    }


}
