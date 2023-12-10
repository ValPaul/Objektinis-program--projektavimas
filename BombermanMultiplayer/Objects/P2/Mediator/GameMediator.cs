using System;
using System.Collections.Generic;

namespace BombermanMultiplayer.Objects.P2.Mediator
{
    public class GameMediator : IGameMediator
    {
        private Dictionary<string, List<Action<object>>> eventHandlers = new Dictionary<string, List<Action<object>>>();

        public void Notify(object sender, string eventName)
        {
            if (eventHandlers.ContainsKey(eventName))
            {
                foreach (var handler in eventHandlers[eventName])
                {
                    handler.Invoke(sender);
                }
            }
        }

        public void Subscribe(string eventName, Action<object> handler)
        {
            if (!eventHandlers.ContainsKey(eventName))
            {
                eventHandlers[eventName] = new List<Action<object>>();
            }

            eventHandlers[eventName].Add(handler);
        }

        public void Unsubscribe(string eventName, Action<object> handler)
        {
            if (eventHandlers.ContainsKey(eventName))
            {
                eventHandlers[eventName].Remove(handler);
            }
        }
    }
}