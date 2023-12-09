using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombermanMultiplayer.Objects.P2.Flyweight
{
    public class Fire : GameObject
    {

        int _x, _y;
        FireType _type;
        int _firetimer;

        public Fire(int x, int y, FireType type) : base(x, y, 1, 48, 48)
        {
            _x = x;
            _y = y;
            _type = type;
            _firetimer = 500;
        }

        public void Draw()
        {
            LoadSprite(_type._texture);

            while (_firetimer > 0)
            {
                _firetimer--;

                if (_firetimer == 0)
                    Remove();
            }

        }

        public void Remove()
        {
            UnloadSprite();
        }

    }
}
