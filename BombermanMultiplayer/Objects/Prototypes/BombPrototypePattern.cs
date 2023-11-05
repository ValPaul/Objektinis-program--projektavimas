using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Media;
using System.Diagnostics;

namespace BombermanMultiplayer
{
    public interface ICloneable<T>
    {
        T Clone();
    }


    [Serializable]
    public abstract class BombPrototype
    {
        
        public int DetonationTime { get; set; }
        public bool Explosing { get; set; }
        public int BombPower { get; set; }
        public short Proprietary { get; set; }

        public abstract BombPrototype Clone();
    }

    [Serializable]
    public class Bomb : BombPrototype
    {
       
        public Bomb(int detonationTime, int bombPower, short proprietary)
        {
            DetonationTime = detonationTime;
            BombPower = bombPower;
            Proprietary = proprietary;
        }

        public override BombPrototype Clone()
        {
            
            return new Bomb(DetonationTime, BombPower, Proprietary);
        }
    }

    [Serializable]
    public class Bomb2 : BombPrototype
    {
        
        public Bomb2(int detonationTime, int bombPower, short proprietary)
        {
            DetonationTime = detonationTime;
            BombPower = bombPower;
            Proprietary = proprietary;
        }

        public override BombPrototype Clone()
        {
           
            return new Bomb2(DetonationTime, BombPower, Proprietary);
        }
    }


    // Create a Bomb prototype
    //BombPrototype bombPrototype = new Bomb(2000, 3, 1);

    // Clone the Bomb prototype
    //BombPrototype clonedBomb = bombPrototype.Clone();

    // Create a Bomb2 prototype
    //BombPrototype bomb2Prototype = new Bomb2(2000, 3, 2);

    // Clone the Bomb2 prototype
    //BombPrototype clonedBomb2 = bomb2Prototype.Clone();
}
