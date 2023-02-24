using UnityEngine;

namespace SingletonPattern
{
    public class SingletonManager : MonoBehaviour
    {
        public static SingletonManager Instance { get; private set; }

        void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Debug.Log("Desrtoy " + this);
                Destroy(this);
            }
            else
            {
                Debug.Log("Instance = " + this);
                Instance = this;
            }
        }

        public void Function_A()
        {
            Debug.Log("Singleton Manager Function A is called");
        }
    }
}