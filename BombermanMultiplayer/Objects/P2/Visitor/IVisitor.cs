using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.P2.Visitor
{
    public interface IVisitor
    {
        void Visit(Bonus bonus);
        void Visit(Bomb bomb);

        void Visit(NonExplosiveBomb bomb);
    }
}
