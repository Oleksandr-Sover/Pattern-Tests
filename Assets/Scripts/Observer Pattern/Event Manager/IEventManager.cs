
namespace ObserverPattern
{
    public delegate void OnEvent_A();
    public interface IEventManager
    {
        event OnEvent_A onEvent_A;
        void InvokeEvent_A();
    }
}