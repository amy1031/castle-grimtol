using System;
using CastleGrimtol.GameData;

namespace CastleGrimtol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var game = new Game();
            game.Playing = true;
            game.Setup();

            //game loop
            while (game.Playing)
            {
                Console.Write("\nWhat would you like to do? ");
                var userInput = Console.ReadLine();
                var userChoice = userInput.Split(' ');

                if (userInput.ToLower() == "quit" || userInput.ToLower() == "q")
                {
                    game.Playing = false;
                }
                else if (userInput.ToLower() == "help" || userInput.ToLower() == "h")
                {
                    game.GetHelp();
                }
                else if (userInput.ToLower() == "north" || userInput.ToLower() == "n")
                {
                    game.Move("north");
                }
                else if (userInput.ToLower() == "south" || userInput.ToLower() == "s")
                {
                    game.Move("south");
                }
                else if (userInput.ToLower() == "east" || userInput.ToLower() == "e")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("You can't go that way.");
                    Console.WriteLine("You've fallen into a pit of lava!");
                    Console.WriteLine("You should have listened to us.");
                    Console.WriteLine("Now you're dead.");
                    Console.WriteLine("Goodbye.");
                    game.Playing = false;
                }
                else if (userInput.ToLower() == "west" || userInput.ToLower() == "w")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("You can't go that way.");
                    Console.WriteLine("You have somehow fallen into a black hole!");
                    Console.WriteLine("How did a black hole get in a cave?");
                    Console.WriteLine("Doesn't matter. Now you're dead.");
                    Console.WriteLine("It was nice knowing you.");
                    game.Playing = false;
                }
                else if (userInput.ToLower() == "inventory" || userInput.ToLower() == "i")
                {
                    game.CurrentPlayer.PlayerInventory(game.CurrentPlayer);
                }
                else if (userInput.ToLower() == "take" || userInput.ToLower() == "t")
                {
                    game.TakeItem("item");
                }
                else if (userInput.ToLower() == "reset" || userInput.ToLower() == "r")
                {
                    game.Reset();
                }
                else if (userInput.ToLower() == "use")
                {
                    game.UseItem("item");
                }
                else
                {
                    Console.WriteLine("I do not understand that request.");
                }
            }

        }
    }
}