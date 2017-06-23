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
                var userInput = Console.ReadLine().Split(' ');
                var userChoice = userInput[0];
               // var userParameters = userChoice.Split(' ')[1];

                if (userChoice.ToLower() == "quit" || userChoice.ToLower() == "q")
                {
                    game.Playing = false;
                }
                else if (userChoice.ToLower() == "help" || userChoice.ToLower() == "h")
                {
                    game.GetHelp();
                }
                else if (userChoice.ToLower() == "north" || userChoice.ToLower() == "n")
                {
                    game.Move("north");
                }
                else if (userChoice.ToLower() == "south" || userChoice.ToLower() == "s")
                {
                    game.Move("south");
                }
                else if (userChoice.ToLower() == "east" || userChoice.ToLower() == "e")
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
                else if (userChoice.ToLower() == "west" || userChoice.ToLower() == "w")
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
                else if (userChoice.ToLower() == "inventory" || userChoice.ToLower() == "i")
                {
                    game.CurrentPlayer.PlayerInventory(game.CurrentPlayer);
                }
                else if (userChoice.ToLower() == "take" || userChoice.ToLower() == "t"  && userInput[1] != null)
                {
                    game.TakeItem(userInput[1]);
                }
                else if (userChoice.ToLower() == "reset" || userChoice.ToLower() == "r")
                {
                    game.Reset();
                }
                else if (userChoice.ToLower() == "use"  && userInput[1] != null)
                {
                    game.UseItem(userInput[1]);
                }
                else if (userChoice.ToLower() == "go" && userInput[1] != null) 
                {
                    game.Move(userInput[1]);
                }
                else
                {
                    Console.WriteLine("I do not understand that request.");
                }
            }

        }
    }
}