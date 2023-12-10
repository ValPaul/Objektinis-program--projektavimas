using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.P2.Memento
{
    public class PlayerMemento
    {
        public int[] CasePosition { get; }
        public byte Lifes { get; }
        public byte BombNumb { get; }
        public byte Vitesse { get; }
        public bool Dead { get; }
        public BonusType[] BonusSlot { get; }
        public short[] BonusTimer { get; }

        public PlayerMemento(Player player)
        {
            CasePosition = new int[] { player.CasePosition[0], player.CasePosition[1] };
            Lifes = player.Lifes;
            BombNumb = player.BombNumb;
            Vitesse = player.Vitesse;
            Dead = player.Dead;
            BonusSlot = player.BonusSlot.Clone() as BonusType[];
            BonusTimer = player.BonusTimer.Clone() as short[];
        }
    }
}
