using System.Collections.Generic;

namespace CastleGrimtol.GameData
{
    public interface IRoom
    {
        string Name { get; set; }
        string Description { get; set; }
        List<Item> Items { get; set; }

        //currentRoom.UseItem
        //
        void UseItem(Item item);

    }
}