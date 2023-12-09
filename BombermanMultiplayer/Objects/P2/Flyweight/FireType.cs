using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BombermanMultiplayer.Objects.P2.Flyweight
{
    public class FireType
    {

        public Image _texture;
        public string _name;
        public string _color;

        public FireType (Image texture, string name, string color)
        {
            _texture = texture;
            _name = name;
            _color = color;
        }

    }
}
