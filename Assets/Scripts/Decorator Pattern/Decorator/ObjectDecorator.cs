
namespace DecoratorPattern
{
    public abstract class ObjectDecorator : IObject
    {
        protected IObject Object;

        public ObjectDecorator(IObject Object) => this.Object = Object;

        public virtual void Action() => Object.Action();
    }
}