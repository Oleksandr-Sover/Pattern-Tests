using UnityEngine;

namespace DecoratorPattern
{
    public class SimpleObject : IObject
    {
        public void Action()
        {
            Debug.Log("Action is done");
        }
    }
}