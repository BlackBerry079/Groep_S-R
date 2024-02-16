using System.Runtime.InteropServices;
namespace Pokemon_Battle_Sim
{
    internal class Program
    {

        class Pokemon
        {
            public string name;
            public string strength;
            public string weakness;
            public string attack;

            public Pokemon(string name, string strength, string weakness, string attack)
            {
                this.name = name;
                this.strength = strength;
                this.weakness = weakness;
                this.attack = attack;
            }

            public string getName()
            {
                return name;
            }

            public void setName(string name)
            {
                this.name = name;
            }

            public string growl()
            {
                return "GROOOWWWL!!!";
            }
        }

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

            public void open()
            {

            }

            public void close()
            {

            }
        }

        class Battle
        {
            public static void Main(string[] args)
            {
                Pokemon charmander = new Pokemon("", "Fire", "Water", "Growl");
                Pokeball pokeball = new Pokeball(80, "Red", charmander);
                Console.WriteLine("Welcome to the Pokemon Battle Simulator!");
                while (true)
                {
                    Console.WriteLine("What do you want to call your charmander?");
                    string name = Console.ReadLine();
                    charmander.name = name;
                    if (name != "")
                    {
                        Console.WriteLine(charmander.name + " used " + charmander.attack);
                        for (int i = 0; i < 11; i++)
                        {
                            Console.WriteLine(charmander.growl());
                        }
                        Console.WriteLine("Do you want to change the name of your " + charmander.name + "? (Type no to quit)");
                        string repeat = Console.ReadLine();
                        if (repeat != "yes" && repeat != "no")
                        {
                            Console.WriteLine("Type 'yes' or 'no'!");
                        }
                        else if (repeat == "no")
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}