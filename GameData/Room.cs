using System;
using System.Collections.Generic;

namespace CastleGrimtol.GameData
{
    public class Room : IRoom
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; }
        public Dictionary<string, Room> Exits = new Dictionary<string, Room>();
       // public Dictionary<string, bool> BlockedExit = new Dictionary<string, bool>();
        public bool BlockedExit { get; set; }
        public Dictionary<string, string> UseableItems = new Dictionary<string, string>();

        public Room(string name, string description, bool blockedExit, Dictionary<string, string> usableItems)
        {
            Name = name;
            Description = description;
            Items = new List<Item>();
            BlockedExit = blockedExit;
            UseableItems = usableItems;
            // foreach(var exit in blockedExits)
            // {
            //     BlockedExit[exit] = true;
            // }
        }

        public void UseItem(Item item)
        {
            //var use = UseableItems[item.Name];
           // var usable = UseableItems[item.Name];
            if(UseableItems.ContainsKey(item.Name.ToLower()))
            {
                Console.WriteLine($"Using {item.Name}");
                if(item.Unlocks)
                {
                    Console.WriteLine("unlocking room");
                    BlockedExit = false;
                }
            }
            else
            {
                Console.WriteLine("You can't use that here");
            }
        }

        public void AddExit(Room room, string direction)
        {
            Exits.Add(direction, room);
        }
        public bool CheckExit(string direction)
        {
            return Exits.ContainsKey(direction) && !BlockedExit;
        }
        public void EnterRoom()
        {
            Console.WriteLine("\n You are in the " + Name);
            Console.WriteLine(Description);
        }
    }
}