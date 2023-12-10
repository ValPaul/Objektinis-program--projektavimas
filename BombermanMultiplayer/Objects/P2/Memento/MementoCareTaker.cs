using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.P2.Memento
{
    public class MementoCareTaker
    {
        private readonly Stack<GameMemento> mementos = new Stack<GameMemento>();

        public void AddMemento(GameMemento memento)
        {
            mementos.Push(memento);
        }

        public GameMemento GetLastMemento()
        {
            if (mementos.Count > 0)
            {
                return mementos.Pop();
            }

            return null;
        }
    }
}
