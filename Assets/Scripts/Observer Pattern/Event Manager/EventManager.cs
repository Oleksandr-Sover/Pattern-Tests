using UnityEngine;

namespace ObserverPattern
{
    public class EventManager : MonoBehaviour, IEventManager
    {
        public event OnEvent_A onEvent_A;
        public void InvokeEvent_A() => onEvent_A?.Invoke(); // or: if (onEvent_A != null) onEvent_A();
    }
}