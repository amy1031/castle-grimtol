using System;
using System.Collections.Generic;

namespace CastleGrimtol.GameData
{
    public class Game : IGame
    {
        //you may end up extending these classes
        public Room CurrentRoom { get; set; }
        public Player CurrentPlayer { get; set; }

        public void Setup() 
        {
            Console.WriteLine("///////////////////////////////////////////////////////////");
            Console.WriteLine("Are you okay? Are you hurt?");
            CurrentPlayer = new Player();
        }

        public void GetHelp()
        {
            Console.WriteLine("///////////////////////////////////////////////////////////");
            Console.WriteLine("The rules are simple.");
            Console.WriteLine(@"Make your way through each area by typing in the direction you want to go.
                    
                    You can choose from the following: 
                        'go north' or 'n',
                        'go south' or 's'
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
            Console.WriteLine("If you want to quit, you can type in 'quit' or 'q' to exit.");
            Console.WriteLine("///////////////////////////////////////////////////////////");
        }

        public void Rooms() 
        {
            var shaft = new Room("Shaft", "It looks like you have fallen through a cave shaft and now you are the bottom of a cave. Oh no! It looks like the shaft is about to cave in! You better go north through the tunnel to find another way out!");
            var caveA = new Room("Cave A", "It's very dark and muggy in this part of the cave.");
            var caveB = new Room("Cave B", "There are many large boulders everywhere. There are bats up above.");
            var caveC = new Room("Cave C", "There is a small pond. The air is starting to seem less muggy.");
            var meadow = new Room("Meadow", "Wow, what a beautiful sight. You see a large empty meadow in front of you, filled with lavendar and oak trees.");
        }

        public void Items()
        {
            var flashlight = new Item("Flashlight", "Now you can see better.");
            var axe = new Item("Axe", "Cuts through wood with some extreme effort.");
        }

        public void Reset()
        {

        }

        public void UseItem(string itemName)
        {

        }
    }
}