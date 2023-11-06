﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.Prototype
{
public interface IBombFactory
{

    IBomb CreateBomb(BombType type, int caseLigne, int caseCol, int totalFrames, int frameWidth, int frameHeight, int detonationTime, int TileWidth, int TileHeight, short proprietary);

}
}
