using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.Observer
{
    public class ObserverManager
    {

        private List<Observer> _observer = new List<Observer>();

        public void subscribe(Observer observer)
        {
            _observer.Add(observer);
        }

        public void unsubscribe(Observer observer)
        {
            _observer.Remove(observer);
        }

        public void Notify(string text)
        {

            foreach(var observer in _observer)
            {
                observer.update(text);
            }

        }

    }
}
