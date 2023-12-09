using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.P2.Iterator
{
    public interface ICollection
    {

        IIterator createIterator();

    }
}
