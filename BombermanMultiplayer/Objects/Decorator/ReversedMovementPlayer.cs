using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer
{
    public class DoubleMovementPlayer : PlayerDecorator
    {
        public DoubleMovementPlayer(IPlayer player) : base(player)
        {

        }

        public override void Move()
        {
            base.Move();
            base.Move();
        }

    }
}
