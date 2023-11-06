using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.Prototype
{
    public interface IPrototype<T>
    {
        T ShallowCopy();
        T DeepCopy();
    }
}
