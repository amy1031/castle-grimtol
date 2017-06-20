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
            //create all rooms var livingRoom = new Room()
            //relationships/exits from each room - create a dictionary in room with exits
            //create all items here first
            Console.WriteLine("///////////////////////////////////////////////////////////");
            Console.WriteLine("Are you okay? Are you hurt?");
            //Console.WriteLine("What is your name?");
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
            var caveA = new Room("Cave A", "DOUBLE BLARG");
            var caveB = new Room("Cave B", "TRIPLE BLARG");
            var meadow = new Room("Meadow", "Wow, what a beautiful sight. You see a large empty meadow in front of you, filled with lavendar and oak trees.");
        }

        public void Reset()
        {

        }

        public void UseItem(string itemName)
        {

        }
        public void Start()
        {
            //game loop here
        }
    }
}