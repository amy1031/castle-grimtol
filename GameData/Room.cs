using System.Collections.Generic;

namespace CastleGrimtol.GameData
{
    public class Room : IRoom
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; }

        public void UseItem(Item item)
        {

        }
    }
}