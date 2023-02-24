using UnityEngine;

namespace ObserverPattern
{
    public class EventHandler : MonoBehaviour
    {
        IEventManager EventManager;

        void Awake()
        {
            EventManager = FindObjectOfType<EventManager>();
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                EventManager.InvokeEvent_A();
            }
        }
    }
}