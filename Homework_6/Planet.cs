using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    internal class Planet
    {
        public Planet(string name, int number, int equatorLength, string lastPlanet)
        {
            Name = name;
            Number = number;
            EquatorLength = equatorLength;
            LastPlanet = lastPlanet;
        }

        public string Name  { get; }

        public int Number { get; }

        public int EquatorLength { get; }

        public string LastPlanet { get; }
    }
}
