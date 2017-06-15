using System.Collections.Generic;

namespace CastleGrimtol.GameData
{
    public class Player : IPlayer
    {
        public int Score { get; set; }
        public List<Item> Inventory { get; set; }
    }
}