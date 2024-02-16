using System.Runtime.InteropServices;
namespace Pokemon_Battle_Sim
{
    internal class Program
    {

        class Battle
        {
            public static void Main(string[] args)
            {
                Pokemon charmander = new Pokemon("charmander", "Fire", "Water", "Growl");
                Pokeball pokeball = new Pokeball(80, "Red", charmander);
                Trainer trainer = new Trainer("", new List<Pokeball>(6));
                Console.WriteLine("Welcome to the Pokemon Battle Simulator!");

                while (true)
                {
                    Console.WriteLine("What is the first trainers name?");
                    String name1 = Console.ReadLine();
                    Console.WriteLine("What is the second trainers name?");
                    string name2 = Console.ReadLine();
                    if (name1 != "" && name2 != "")
                    {
                        for (int i = 0; i < 7; i++)
                        {
                            Console.WriteLine(name1 + " throws his pokeball");
                            Console.WriteLine(charmander.name + pokeball.open() + charmander.attack);
                            Console.WriteLine(name2 + " throws his pokeball");
                            Console.WriteLine(charmander.name + pokeball.open() + charmander.attack);
                            Console.WriteLine(charmander.name + pokeball.close() + name1);
                            Console.WriteLine(charmander.name + pokeball.close() + name2 + "\n");
                        }
                    }
                    Console.WriteLine("Do you want to restart? (Type 'no' to quit)");
                    String restart = Console.ReadLine();
                    if (restart != "yes" && restart != "no")
                    {
                        Console.WriteLine("Type 'yes' or 'no'!");
                    }
                    else if (restart == "no")
                    {
                        break;
                    }
                }


/*              while (true)
                {
                    Console.WriteLine("What do you want to call your charmander");
                    string name = Console.ReadLine();
                    charmander.name = name;
                    if (name != "")
                    {
                        for (int i = 0; i < 11; i++)
                        {
                            Console.WriteLine(charmander.name + " used " + charmander.attack);
                            Console.WriteLine(charmander.growl() + "\n");
                        }
                        Console.WriteLine("Do you want to change the name of your " + charmander.name + "? (Type 'no' to quit)");
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
                }*/
                }
        }
    }
}