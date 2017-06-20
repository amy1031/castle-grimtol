using System;
using CastleGrimtol.GameData;

namespace CastleGrimtol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var game = new Game();
            game.Setup();

            //game loop
            bool playing = true;
            while (playing)
            {
                var userInput = Console.ReadLine();
                var userChoice = userInput.Split(' ');

                if (userInput.ToLower() == "quit" || userInput.ToLower() == "q")
                {
                    playing = false;
                }
                else if (userInput.ToLower() == "help" || userInput.ToLower() == "h")
                {
                    game.GetHelp();
                }
                else if (userInput.ToLower() == "north" || userInput.ToLower() == "n")
                {
                     Console.WriteLine("north");
                }
                else if (userInput.ToLower() == "south" || userInput.ToLower() == "s")
                {
                     Console.WriteLine("south");
                }
                else if (userInput.ToLower() == "east" || userInput.ToLower() == "e")
                {
                     Console.WriteLine("You can't go that way.");
                     Console.WriteLine("You've fallen into a pit of lava!");
                     Console.WriteLine("You should have listened to us.");
                     Console.WriteLine("Now you're dead.");
                     Console.WriteLine("Goodbye.");
                     playing = false;
                }
                else if (userInput.ToLower() == "west" || userInput.ToLower() == "w")
                {
                     Console.WriteLine("You can't go that way.");
                     Console.WriteLine("You have somehow fallen into a black hole!");
                     Console.WriteLine("How did a black hole get in a cave?");
                     Console.WriteLine("Doesn't matter. Now you're dead.");
                     Console.WriteLine("It was nice knowing you.");
                     playing = false;
                }
                else if (userInput.ToLower() == "inventory" || userInput.ToLower() == "i")
                {
                    Console.WriteLine("inventory");
                }
                else if (userInput.ToLower() == "take" || userInput.ToLower() == "t")
                {
                    Console.WriteLine("Take");
                }
                else if (userInput.ToLower() == "use")
                {
                    Console.WriteLine("use");
                }
                else
                {
                    Console.WriteLine("I do not understand that request.");
                }
            }

        }
    }
}