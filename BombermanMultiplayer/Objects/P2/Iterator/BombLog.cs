using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.P2.Iterator
{
    public class BombLog
    {

        string log;

        public BombLog (string log)
        {
            this.log = log;
        }

        public string getLog()
        {
            return this.log;
        }

    }
}
