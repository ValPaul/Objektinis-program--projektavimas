using System;
using System.Collections.Generic;

namespace BombermanMultiplayer.Objects
{
    public class BombermanFacade
    {
        private readonly IBombAbstractFactory normalBombFactory;
        private readonly IBombAbstractFactory explosiveBombFactory;
        private readonly IBombAbstractFactory nonExplosiveBombFactory;

        public BombermanFacade()
        {
            normalBombFactory = new BombFactory();
            explosiveBombFactory = new ExplosiveBombFactory();
            nonExplosiveBombFactory = new NonExplosiveBombFactory();
        }

        public IBomb CreateBomb(BombType type, int caseLigne, int caseCol, int totalFrames, int frameWidth, int frameHeight, int detonationTime, int TileWidth, int TileHeight, short proprietary)
        {
            switch (type)
            {
                case BombType.Normal:
                    return normalBombFactory.CreateBomb(type, caseLigne, caseCol, totalFrames, frameWidth, frameHeight, detonationTime, TileWidth, TileHeight, proprietary);
                case BombType.Explosive:
                    return explosiveBombFactory.CreateBomb(type, caseLigne, caseCol, totalFrames, frameWidth, frameHeight, detonationTime, TileWidth, TileHeight, proprietary);
                case BombType.NonExplosive:
                    return nonExplosiveBombFactory.CreateBomb(type, caseLigne, caseCol, totalFrames, frameWidth, frameHeight, detonationTime, TileWidth, TileHeight, proprietary);
                default:
                    throw new ArgumentException("Unsupported bomb type");
            }
        }

        // Add more methods for managing bombs in your game if needed
    }
}
