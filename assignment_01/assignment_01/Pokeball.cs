using System;

// Pokeball class
class Pokeball
{
    private Charmander charmander;

    // Method to release the Charmander
    public void ReleaseAndBattleCry(Charmander pokemon)
    {
        Console.WriteLine("The pokeball is thrown, which opens it up and released the charmander inside of it.\nThe charmander does its battle cry.");
        charmander = pokemon;
        charmander.BattleCry();
        Console.WriteLine("The charmander is then returned to the pokeball.\n");
    }
}

// ------------------------------------------------ klemboard ------------------------------------------------


// Pokeball class
//lass Pokeball
//{
// the pokeball is open(true) or closed(false). I
//    private bool isOpen = false;  // Field to store whether the pokeball is open
//    private Charmander charmander;

// Method to open the pokeball
//    public void Open()
//    {
//        isOpen = true; // Set the isOpen field to true
//    }

// Method to release the Charmander
//    public void ReleaseAndBattleCry(Charmander pokemon)
//    {
///        Console.WriteLine("The pokeball released the charmander and charmander does its battle cry.");
//        charmander = pokemon;
//        charmander.BattleCry();
//    }

// Method to return Charmander to the pokeball
//    public void ReturnCharmander()
//    {
//        charmander = null;
//        isOpen = false; // Set the isOpen field to false
//    }
//}