using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;

namespace BombermanMultiplayer.Objects.P2.Flyweight
{
    public class FireFactory
    {

        List<FireType> _fire = new List<FireType>();

        public FireType getFireType(string name, string color, Image texture)
        {
            FireType fireType = null;

            if (_fire.Contains(new FireType(texture, name, color)))
            {
                foreach (var fire in _fire)
                {
                    if (fire._name == name && fire._color == color && fire._texture == texture)
                    {
                        fireType = fire;
                    }
                }
            }
            else
            {
                fireType = new FireType(texture, name, color);
                _fire.Add(fireType);
            }
            
            return fireType;

        }

    }
}
