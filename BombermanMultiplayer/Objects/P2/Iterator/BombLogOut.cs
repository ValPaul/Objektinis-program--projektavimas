using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.P2.Iterator
{
    class BombLogOut
    {
        BombLogCollection bomblog;

        public BombLogOut(BombLogCollection bomblog)
        {
            this.bomblog = bomblog;
        }

        public void printbomblog()
        {
            IIterator iterator = bomblog.createIterator();
            Console.WriteLine("-------BOMB LOG BAR------------");
            while (iterator.hasNext())
            {
                BombLog n = (BombLog)iterator.next();
                Console.WriteLine(n.getLog());
            }
        }
    }
}
