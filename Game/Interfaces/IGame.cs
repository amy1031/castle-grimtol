using System.Collections.Generic;

namespace CastleGrimtol.Game
{
    public interface IGame
    {
        Room CurrentRoom { get; set; }
        Player CurrentPlayer { get; set; }

        void Setup();
        void Reset();

        //No need to Pass a room since Items can only be used in the CurrentRoom
        //This will try to find the item
        //You give the game the name of the item you want to use. The game will tell the current room to use that item.
        //You can only use an item in the room where you are.
        void UseItem(string itemName);

        //you can add to interface but cannot remove anything from the interfaces
    }
}
