using System;

// Trainer class
class Trainer
{
    private string name;
    private List<Pokeball> belt = new List<Pokeball>();

    // Constructor
    public Trainer(string name)
    {
        this.name = name;
        for (int i = 0; i < 6; i++)
        {
            belt.Add(new Pokeball());
        }
    }

    // Method to throw a pokeball
    public void ThrowPokeball()
    {
        Console.WriteLine($"Trainer {name} throws a pokeball!");
        // Logic to throw pokeball
    }

    // Method to return a pokemon back to its pokeball
    public void ReturnPokemon()
    {
        Console.WriteLine($"Trainer {name} returns the pokemon back to its pokeball!");
        // Logic to return pokemon
    }

    // Method to get the trainer's name
    public string GetName()
    {
        return name;
    }
}