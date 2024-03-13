using System.Runtime.InteropServices;
namespace Pokemon_Battle_Sim
{
    internal class Program
    {
        class Battle
        {
            public static void Main(string[] args)
            {
                Charmander charmander = new Charmander("charmander", "fire", "water");
                Pokeball pokeball = new Pokeball(charmander);

                Charmander release = pokeball.Open();
                pokeball.Close(release);

                Console.WriteLine("Welcome to the Pokemon Battle Simulator!");
                Console.WriteLine("What is the name of the first trainer?");
                string FirstName = Console.ReadLine();
                Trainer trainer1 = new Trainer(FirstName);
                Console.WriteLine($"Trainer 1 is called: {FirstName}");

                for (int i = 0; i < 6; i++)
                {
                    trainer1.TakePokeball(pokeball);
                }

                Console.WriteLine("What is the name of the first trainer?");
                string SecondName = Console.ReadLine();
                Trainer trainer2 = new Trainer(SecondName);
                Console.WriteLine($"Trainer 2 is called: {SecondName}");

                for (int i = 0; i < 6; i++)
                {
                    trainer2.TakePokeball(pokeball);
                }

                for (int i = 0; i < 6; i++)
                {
                    Charmander first = trainer1.ReleasePokemon();
                    Charmander second = trainer2.ReleasePokemon();

                    Console.WriteLine($"The Charmander of {FirstName} is released");
                    Console.WriteLine($"The Charmander uses growl: '{first.Growl()}' ");
                    Console.WriteLine($"The Charmander of {SecondName} is released");
                    Console.WriteLine($"The Charmander uses growl: '{second.Growl()}' \n");

                    trainer1.ReturnPokemon(first);
                    trainer2.ReturnPokemon(second);

                    Console.WriteLine($"The Charmander of {FirstName} is returned");
                    Console.WriteLine($"The Charmander of {SecondName} is returned \n");
                }

            }
        }
    }
}