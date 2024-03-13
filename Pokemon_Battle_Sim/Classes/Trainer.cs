using System;
namespace Pokemon_Battle_Sim
{
    internal class Trainer
    {
        public string name;
        public List<Pokeball> belt;
        public int index = 0;

        public Trainer(string name)
        {
            this.name = name;
            this.belt = new List<Pokeball>();
        }

        public void TakePokeball(Pokeball pokeball)
        {
            belt.Add(pokeball);
        }

        public Charmander ReleasePokemon()
        {
            Pokeball pokeball = belt[index];
            Charmander charmander = pokeball.Open();
            return charmander;
        }

        public void ReturnPokemon(Charmander charmander)
        {
            Pokeball pokeball = belt[index++];
            pokeball.Close(charmander);
        }
    }
}