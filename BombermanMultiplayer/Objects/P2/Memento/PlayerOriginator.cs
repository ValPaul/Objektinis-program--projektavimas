using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.P2.Memento
{
    public class PlayerOriginator
    {
        public PlayerMemento CreateMemento(Player player)
        {
            return new PlayerMemento(player);
        }

        public void SetMemento(Player player, PlayerMemento memento)
        {
            player.CasePosition = new int[] { memento.CasePosition[0], memento.CasePosition[1] };
            player.Lifes = memento.Lifes;
            player.BombNumb = memento.BombNumb;
            player.Vitesse = memento.Vitesse;
            player.Dead = memento.Dead;
            player.BonusSlot = memento.BonusSlot.Clone() as BonusType[];
            player.BonusTimer = memento.BonusTimer.Clone() as short[];
        }
    }
}
