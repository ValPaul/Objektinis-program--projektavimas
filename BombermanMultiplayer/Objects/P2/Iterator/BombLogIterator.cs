using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.P2.Iterator
{
    public class BombLogIterator : IIterator
    {

        BombLog[] BombLogList;

        int pos = 0;

        public BombLogIterator(BombLog[] bombloglist)
        {
            this.BombLogList = bombloglist;
        }

        public bool hasNext()
        {
            if (pos >= BombLogList.Length || BombLogList[pos] == null)
                return false;
            else
                return true;
        }

        public object next()
        {
            BombLog bomblog = this.BombLogList[pos++];

            return bomblog;

        }
    }
}
