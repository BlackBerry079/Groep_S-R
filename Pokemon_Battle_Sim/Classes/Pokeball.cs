using System;
namespace Pokemon_Battle_Sim
{
    class Pokeball
    {
        public int catchRate;
        public string color;
        public Pokemon pokemon;

        public Pokeball(int catchRate, string color, Pokemon pokemon)
        {
            this.catchRate = catchRate;
            this.color = color;
            this.pokemon = pokemon;
        }

        public string open()
        {
            return " is released and uses ";
        }

        public string close()
        {
            return " is returned by ";
        }
    }
}