using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindACouple
{
    internal class Player
    {
        

        public Player(string name, double timerCount)
        {
            Name = name;
            
            Time = timerCount;
        }

        public string Name { get; private set; }   
        public double Time { get; private set; }
    }
}
