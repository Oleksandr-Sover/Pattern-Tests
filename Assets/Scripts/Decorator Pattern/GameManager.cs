using UnityEngine;

namespace DecoratorPattern
{
    public class GameManager : MonoBehaviour
    {
        void Start()
        {
            IObject simpleObject = new SimpleObject();
            simpleObject.Action();

            simpleObject = new AddedActionDecorator(simpleObject);
            simpleObject.Action();

            simpleObject = new СhangedActionDecorator(simpleObject);
            simpleObject.Action();

            simpleObject = new AddedParametersDecorator(simpleObject, 10);
            simpleObject.Action();
        }
    }
}