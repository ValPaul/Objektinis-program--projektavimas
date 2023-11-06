using System;
using System.Drawing;

namespace BombermanMultiplayer.Objects
{
    public class Bonus : GameObject
    {
        public BonusType Type = BonusType.None;

        private Bonus()
        {
            // Private constructor to enforce the use of the builder.
        }

        public class BonusBuilder
        {
            private Bonus _bonus;

            public BonusBuilder(int x, int y, int frameNumber, int frameWidth, int frameHeight)
            {
                _bonus = new Bonus
                {
                    _Source = new Rectangle(x, y, frameWidth, frameHeight),
                    _totalFrames = frameNumber
                };
            }

            public BonusBuilder WithType(BonusType type)
            {
                _bonus.Type = type;
                return this;
            }

            public Bonus Build()
            {
                // You can add any additional validation logic here.
                return _bonus;
            }
        }

        public void CheckCasePosition(int TileWidth, int TileHeight)
        {
            this.CasePosition[0] = this.Source.Y / TileWidth; // Ligne
            this.CasePosition[1] = this.Source.X / TileWidth; // Colonne
        }
    }

    public enum BonusType
    {
        None,
        PowerBomb,
        SpeedBoost,
        Desamorce,
        Armor
    }
}
