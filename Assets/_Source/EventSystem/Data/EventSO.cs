using System.Collections.Generic;
using UnityEngine;

namespace EventSystem.Data
{
    [CreateAssetMenu(fileName = "EventSO", menuName = "SO/Event", order = 0)]
    public class EventSO : ScriptableObject
    {
        private readonly List<IGameEventListener> _listeners = new ();

        public void RegisterObserver(IGameEventListener listener)
        {
            _listeners.Add(listener);
        }

        public void RemoveObserver(IGameEventListener listener)
        {
            _listeners.Remove(listener);
        }

        public void Notify()
        {
            for (int i = 0; i < _listeners.Count; i++)
            {
                _listeners[i].Notify();
            }
        }
    }
}