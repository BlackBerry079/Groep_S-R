using System;
namespace Pokemon_Battle_Sim
{

    internal class Pokeball
    {
        public Charmander charmander;
        public bool CharmanderInside;

        public Pokeball(Charmander charmander)
        {
            this.charmander = charmander;
            this.CharmanderInside = true;
        }

        public Charmander Open()
        {
            return this.charmander;
        }

        public void Close(Charmander charmander)
        {
            this.charmander = charmander;
        }

        public bool GetCharmander()
        {
            return CharmanderInside;
        }
    }
}