using System;
namespace Pokemon_Battle_Sim
{
    class Trainer
    {
        public string name;
        public List<Pokeball> belt;

        public Trainer(string name, int belt)
        {
            this.name = name;
            this.belt = belt;
        }
    }
}