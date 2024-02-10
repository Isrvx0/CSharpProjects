using System;
using System.Collections.Generic;

class Program
{
    // Declare playAgain field at the class level
    public static bool playAgain = true;

    static void Main(string[] args)
    {
        // Start the game
        StartGame();
    }

    // Method to start the game
    static void StartGame()
    {
        Console.WriteLine("Welcome to the Pokemon Battle Simulator!");

        // Ask if the user wants to play
        while (playAgain)
        {
            // Ask for a name for the first trainer
            Console.WriteLine("Enter a name for the first trainer or 'quit' to exit:");
            string trainer1Name = Console.ReadLine();

            if (trainer1Name.ToLower() == "quit")
            {
                playAgain = false;
                break;
            }

            // Ask for a name for the second trainer
            Console.WriteLine("Enter a name for the second trainer:");
            string trainer2Name = Console.ReadLine();

            // Create trainers
            Trainer trainer1 = new Trainer(trainer1Name);
            Trainer trainer2 = new Trainer(trainer2Name);

            // Create Charmander
            Charmander charmander = new Charmander("Charmander");

            // Create a new pokeball for each battle
            Pokeball pokeball = new Pokeball();

            // Start the battle with the pokeball
            StartBattle(trainer1, trainer2, pokeball);
        }

        Console.WriteLine("Thanks for playing!");
    }

    // Method to start the battle
    static void StartBattle(Trainer trainer1, Trainer trainer2, Pokeball pokeball)
    {
        Console.WriteLine($"Trainer {trainer1.GetName()} challenges Trainer {trainer2.GetName()}!");

        for (int i = 0; i < 6; i++)
        {
            // Trainer 1 throws the first pokeball
            trainer1.ThrowPokeball();

            // Step 5: Release Charmander from the pokeball and let it do its battle cry
            pokeball.ReleaseAndBattleCry(new Charmander("Charmander"));
            Console.WriteLine("\n");

            // Trainer 2 throws the first pokeball
            trainer2.ThrowPokeball();

            // Step 5: Release Charmander from the pokeball and let it do its battle cry
            pokeball.ReleaseAndBattleCry(new Charmander("Charmander"));
            Console.WriteLine("\n");

            // Trainer 1 returns the charmander back to its pokeball
            trainer1.ReturnPokemon();

            // Trainer 2 returns the charmander back to its pokeball
            trainer2.ReturnPokemon();
            Console.WriteLine("\n");
        }
    }
}