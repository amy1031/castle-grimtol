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

        public Room(string name, string description)
        {
            Name = name;
            Description = description;
            Items = new List<Item>();
        }

        public void UseItem(Item item)
        {

        }

        public void AddExit(Room room, string direction)
        {
            Exits.Add(direction, room);
        }
        public bool CheckExit(string direction)
        {
            return Exits.ContainsKey(direction);
        }
        public void EnterRoom()
        {
            Console.WriteLine("\n You are in the " + Name);
            Console.WriteLine(Description);
        }
    }
}