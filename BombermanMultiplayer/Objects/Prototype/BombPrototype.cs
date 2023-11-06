using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.Prototype
{
    public class BombPrototype : IPrototype<BombPrototype>
    {

        public BombPrototype ShallowCopy()
        {
            return (BombPrototype)this.MemberwiseClone();
        }

        public BombPrototype DeepCopy()
        {
          
            BombPrototype copy = ShallowCopy();
          

            return copy;
        }
    }
}
