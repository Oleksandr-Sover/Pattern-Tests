using UnityEngine;

namespace DecoratorPattern
{
    public class AddedActionDecorator : ObjectDecorator
    {
        public AddedActionDecorator(IObject Object) : base(Object) { }

        public override void Action()
        {
            base.Action();
            AddedActtion();
        }

        public void AddedActtion() => Debug.Log("Added action is done");
    }

    public class СhangedActionDecorator : ObjectDecorator
    {
        public СhangedActionDecorator(IObject Object) : base(Object) { }

        public override void Action() => ChangedAction();

        void ChangedAction() => Debug.Log("Changed actiond is done");
    }

    public class AddedParametersDecorator : ObjectDecorator
    {
        float parametr;
        public AddedParametersDecorator(IObject Object, float parametr) : base(Object) => this.parametr = parametr;

        public override void Action()
        {
            base.Action();
            float variable = parametr;
            Debug.Log("Added parametr = " + variable);
        }
    }
}