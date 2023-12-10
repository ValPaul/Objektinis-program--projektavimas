using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.P2.Memento
{
    public class MementoOriginator
    {
        public Tile[,] MapGrid { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public GameMemento CreateMemento()
        {
            return new GameMemento(MapGrid, Player1, Player2);
        }

        public void SetMemento(GameMemento memento)
        {
            MapGrid = memento.MapGrid;
            Player1 = memento.Player1;
            Player2 = memento.Player2;
        }
    }
}
