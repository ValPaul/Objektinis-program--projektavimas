using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer
{
    public class PlayerDecorator : IPlayer
    {
        protected IPlayer _player;

        public PlayerDecorator(IPlayer player)
        {
            _player = player;
        }

        public virtual void Move()
        {
            _player.Move();
        }
    }

}
