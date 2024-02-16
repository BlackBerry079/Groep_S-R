using System;
namespace Pokemon_Battle_Sim
{
	class Pokemon
	{
		public string name;
		public string strenght;
		public string weakness;
		public string attack;

		public Pokemon(string name, string strenght, string weakness, string attack)
		{
			this.name = name;
			this.strenght = strenght;
			this.weakness = weakness;
			this.attack = attack;
		}

		public string growl()
		{
			return "GROOOWWWL!!!";
		}
	}
}
