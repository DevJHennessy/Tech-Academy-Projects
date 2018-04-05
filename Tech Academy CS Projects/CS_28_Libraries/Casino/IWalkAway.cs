using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Interface
{
    interface IWalkAway
    {
        //Everything is public in an Interface, you do not declare it.
        //Just like an abstract method, you do not implement it. 
        //Naming convention for an Interface is to start with an uppercase I, hence
        //the IWalkAway name.
        void WalkAway(Player player);

    }
}
