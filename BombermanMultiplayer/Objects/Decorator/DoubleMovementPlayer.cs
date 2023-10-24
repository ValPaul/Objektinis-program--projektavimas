using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static BombermanMultiplayer.Player;

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
    public class RandomMovementPlayer : PlayerDecorator
    {
        public RandomMovementPlayer(IPlayer player) : base(player)
        {

        }

        public override void Move()
        {
            Random r = new Random();
            int rInt = r.Next(0, 3);
            base.Orientation = (MovementDirection)rInt;

            base.Move();
        }

    }
}
