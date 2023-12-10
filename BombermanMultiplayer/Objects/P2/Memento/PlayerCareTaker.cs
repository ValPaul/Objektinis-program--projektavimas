using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.P2.Memento
{
    public class PlayerCareTaker
    {
        private List<PlayerMemento> mementos = new List<PlayerMemento>();

        public void AddMemento(PlayerMemento memento)
        {
            mementos.Add(memento);
        }

        public PlayerMemento GetMemento(int index)
        {
            return mementos[index];
        }
    }
}
