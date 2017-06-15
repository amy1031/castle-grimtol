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

        }
        public void Reset()
        {

        }

        public void UseItem(string itemName)
        {

        }
        public Game()
        {
            
        }
    }
}