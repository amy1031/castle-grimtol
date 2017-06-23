using System.Collections.Generic;

namespace CastleGrimtol.GameData
{
    public class Item : IItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Unlocks { get; set; }

        //use item description - add
        public Item (string name, string description, bool unlocks)
        {
            Name = name;
            Description = description;
            Unlocks = unlocks;
        }
    }
}