using System;
namespace Pokemon_Battle_Sim
{
    internal class Charmander
    {
        public string name;
        public string strength;
        public string weakness;

        public Charmander(string name, string strength, string weakness)
        {
            this.name = name;
            this.strength = strength;
            this.weakness = weakness;
        }

        public string Growl()
        {
            return "Charmander!!!";
        }
    }
}