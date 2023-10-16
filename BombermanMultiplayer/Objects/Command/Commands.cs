using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.Command
{
    public class MoveUpCommand : ICommand
    {
        public void Execute(Player player)
        {
            player.DeplHaut();
        }
    }

    public class MoveDownCommand : ICommand
    {
        public void Execute(Player player)
        {
            player.DeplBas();
        }
    }

    public class MoveLeftCommand : ICommand
    {
        public void Execute(Player player)
        {
            player.DeplGauche();
        }
    }

    public class MoveRightCommand : ICommand
    {
        public void Execute(Player player)
        {
            player.DeplDroite();
        }
    }

    public class NoCommand : ICommand
    {
        public void Execute(Player player)
        {
            player.NO();
        }
    }

    public class NeCommand : ICommand
    {
        public void Execute(Player player)
        {
            player.NE();
        }
    }

    public class SoCommand : ICommand
    {
        public void Execute(Player player)
        {
            player.SO();
        }
    }

    public class SeCommand : ICommand
    {
        public void Execute(Player player)
        {
            player.SE();
        }
    }

}
