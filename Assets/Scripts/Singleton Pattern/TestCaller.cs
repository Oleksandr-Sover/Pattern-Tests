using UnityEngine;

namespace SingletonPattern
{
    public class TestCaller : MonoBehaviour
    {
        void Start()
        {
            Debug.Log("Create a singleton instance");
            Instantiate(FindObjectOfType<SingletonManager>().gameObject);

            Debug.Log("Call a Function A without an instance reference");
            SingletonManager.Instance.Function_A();
        }
    }
}