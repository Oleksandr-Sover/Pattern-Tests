
namespace StatePattern
{
    public interface IState
    {
        void Enter();
        void Execute_A();
        void Execute_B();
        void Exit();
    }
}