using System;
using System.Collections.Generic;

namespace CastleGrimtol.GameData
{
    public class Game : IGame
    {
        public Room CurrentRoom { get; set; }
        public Player CurrentPlayer { get; set; }
        public Boolean Playing { get; set; }

        public void Setup()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("///////////////////////////////////////////////////////////");
            Console.WriteLine("Oh no!");
            Console.WriteLine("Are you okay? Are you hurt?");
            CurrentPlayer = new Player();
            Rooms();
            //  Items();
            CurrentRoom.EnterRoom();
        }

        public void GetHelp()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("///////////////////////////////////////////////////////////");
            Console.WriteLine("The rules are simple.");
            Console.WriteLine(@"Make your way through each area by typing in the direction you want to go.
                    
                    You can choose from the following: 
                        'north' or 'n',
                        'south' or 's'
                    You cannot go east or west.
                    ");
            Console.WriteLine(@"        You can take items and place them in your inventory 
                by typing in 'take' or 'take (item name)'.
                    ");
            Console.WriteLine(@"        You can view your inventory by typing in 'inventory' or 'i'.
                    ");
            Console.WriteLine(@"        You can use any item you have in your inventory 
                by typing in 'use (item name)'.
                    ");
            Console.WriteLine("If you get stuck, you can type in 'help' or 'h' to view this menu again.");
            Console.WriteLine("If you want to reset the game, you can type in 'reset' or 'r' to start over.");
            Console.WriteLine("If you want to quit, you can type in 'quit' or 'q' to exit.");
            Console.WriteLine("///////////////////////////////////////////////////////////");
        }

        public void Rooms()
        {
            var shaft = new Room("Shaft", "It looks like you have fallen through a cave shaft and now you are the bottom of a cave. Oh no! It looks like the shaft is about to cave in! You better go north through the tunnel to find another way out!");
            var caveA = new Room("Cavern", "It's very dark and muggy in this part of the cave. All around you is nothing but limestone.");
            var caveB = new Room("Talus Cave", "There are large boulders everywhere. They have fallen down in random heaps from above.");
            var caveC = new Room("Anchialine cave", "There is a small pond. The air is starting to seem less muggy.");
            var meadow = new Room("Meadow", "Wow, what a beautiful sight. You see a large empty meadow in front of you, filled with lavendar and oak trees. \nYou successfully got out of the cave! \nYou win!");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            CurrentRoom = shaft;

            //add exits
            shaft.AddExit(caveA, "north");
            caveA.AddExit(caveB, "north");
            caveA.AddExit(shaft, "south");
            caveB.AddExit(caveC, "north");
            caveB.AddExit(caveA, "south");
            caveC.AddExit(meadow, "north");
            caveC.AddExit(caveB, "south");
            meadow.AddExit(caveC, "south");

            //add items
            var flashlight = new Item("Flashlight", "Now you can see better.");
            caveA.Items.Add(flashlight);
            var axe = new Item("Axe", "Cuts through wood with some extreme effort.");
            caveB.Items.Add(axe);

            // if (CurrentRoom == caveA)
            // {
            //     CurrentPlayer.Inventory.Add(flashlight);
            // }
            // if (CurrentRoom == caveB)
            // {
            //     CurrentPlayer.Inventory.Add(axe);
            // }
        }

        // void Items()
        // {
        //     var flashlight = new Item("Flashlight", "Now you can see better.");
        //     caveA.Item.Add(flashlight);
        //     var axe = new Item("Axe", "Cuts through wood with some extreme effort.");
        //     caveB.Item.Add(axe);
        // }

        public void Move(string direction)
        {
            if (CurrentRoom.CheckExit(direction))
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                CurrentRoom = CurrentRoom.Exits[direction];
                CurrentRoom.EnterRoom();
                CurrentPlayer.Score += 5;
            }
            else
            {
                Console.WriteLine("You cannot go that way");
            }
        }

        public void TakeItem(string itemName)
        {

        }
        public void UseItem(string itemName)
        {

        }

        public void Reset()
        {
            Console.Clear();
            Setup();
        }

    }
}