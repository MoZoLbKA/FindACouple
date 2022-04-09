using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindACouple
{
    internal class Player
    {
        

        public Player(string name, string surname, double timerCount)
        {
            Name = name;
            Surname = surname;
            Time = timerCount;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public double Time { get; private set; }
    }
}
