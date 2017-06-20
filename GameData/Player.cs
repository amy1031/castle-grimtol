using System;
using System.Collections.Generic;

namespace CastleGrimtol.GameData
{
    public class Player : IPlayer
    {
        public int Score { get; set; }
        public List<Item> Inventory { get; set; }
        public string Character;

        public Player() 
        {
            Character = NewCharacter();
            Inventory = new List<Item>();
            Score = 0;
        }
        public string NewCharacter()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + ". Don't be scared. I can help guide you out of this mess.");
            Console.WriteLine("> > > If you need help, type in 'help' or 'h' at any time. < < <");
            return name;
        }
    }
}