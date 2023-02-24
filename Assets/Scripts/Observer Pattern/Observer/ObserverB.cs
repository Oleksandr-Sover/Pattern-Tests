using UnityEngine;

namespace ObserverPattern
{
    public class ObserverB : MonoBehaviour, IObserver
    {
        IEventManager EventManager;

        void Awake()
        {
            EventManager = FindObjectOfType<EventManager>();
        }

        public void OnEnable()
        {
            EventManager.onEvent_A += DoAction_A;
        }

        public void OnDisable()
        {
            EventManager.onEvent_A -= DoAction_A;
        }

        void DoAction_A()
        {
            Debug.Log(gameObject.name + " - Action A");
        }
    }
}