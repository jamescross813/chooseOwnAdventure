using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");

      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");

      Console.Write("Type YES or NO: ");
      string noiseChoice = Console.ReadLine().ToUpper();

      if (noiseChoice == "NO"){
        Console.WriteLine("Not much of an adventure if you don't leave your room!\n THE END.");
      }else if (noiseChoice == "YES"){
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open i or knock?");
      }
      Console.Write("Type OPEN or KNOCK: ");
      string doorChoice = Console.ReadLine().ToUpper();
    }
  }
}



