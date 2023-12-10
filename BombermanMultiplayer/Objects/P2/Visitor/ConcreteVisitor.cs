using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.P2.Visitor
{
    internal class ConcreteVisitor : IVisitor
    {
        private Player player1;
        private Player player2;
        private object world;

        public void Visit(Bonus bonus)
        {
            Console.WriteLine($"Visited Bonus");
        }

        public void Visit(Bomb bomb)
        {
            Console.WriteLine($"Visited Bomb. Bomb exploded!");
            bomb.DetonationTime = 0;
        }

        public void Visit(NonExplosiveBomb bomb)
        {
            Console.WriteLine($"Visited Bomb. Bomb exploded!");
            bomb.DetonationTime = 0;
        }
    }
}
