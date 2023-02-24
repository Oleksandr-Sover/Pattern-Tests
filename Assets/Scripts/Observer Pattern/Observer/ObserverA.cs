using UnityEngine;

namespace ObserverPattern
{
    public class ObserverA : MonoBehaviour, IObserver
    {
        IEventManager EventManager;

        void Awake()
        {
            EventManager = FindObjectOfType<EventManager>();
        }

        public void OnEnable()
        {
            EventManager.onEvent_A += DoAction_A;
            EventManager.onEvent_A += DoAction_B;
        }

        public void OnDisable()
        {
            EventManager.onEvent_A -= DoAction_A;
            EventManager.onEvent_A -= DoAction_B;
        }

        void DoAction_A()
        {
            Debug.Log(gameObject.name + " - Action A");
        }

        void DoAction_B()
        {
            Debug.Log(gameObject.name + " - Action B");
        }
    }
}