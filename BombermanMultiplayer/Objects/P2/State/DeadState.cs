using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.P2.State
{
    public class DeadState : IState
    {
        public void Alert(string text)
        {
            Console.WriteLine(string.Format("Player {0} is alive", text));
        }
    }
}
