using System.Collections.Generic;

namespace CastleGrimtol.GameData
{
    public interface IPlayer
    {
        int Score { get; set; }
        List<Item> Inventory { get; set; }

    }
}