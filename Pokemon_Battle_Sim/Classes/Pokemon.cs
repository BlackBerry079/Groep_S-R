using System;
namespace Pokemon_Battle_Sim
{
	class Pokemon
	{
		public string name;
		public string strenght;
		public string weakness;

		public Pokemon(string name, string strenght, string weakness)
		{
			this.name = name;
			this.strenght = strenght;
			this.weakness = weakness;
		}

		public string growl()
		{
			return "GROOOWWWL!!! " + name + "!";
		}
	}
}
