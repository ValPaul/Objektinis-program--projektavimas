using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.P2.Memento
{
    public class GameMemento
    {
        public Tile[,] MapGrid { get; }
        public Player Player1 { get; }
        public Player Player2 { get; }

        public GameMemento(Tile[,] mapGrid, Player player1, Player player2)
        {
            MapGrid = DeepCopyMapGrid(mapGrid);
            Player1 = DeepCopyPlayer(player1);
            Player2 = DeepCopyPlayer(player2);
        }

        private static Tile[,] DeepCopyMapGrid(Tile[,] original)
        {
            return original;
        }


        private static Player DeepCopyPlayer(Player original)
        {

            return original; 
        }
    }
}
