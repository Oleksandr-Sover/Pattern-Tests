
namespace StatePattern
{
    public interface IStateInitializer
    {
        IState NewState(IState state);
        IState ChangeState(IState currentState, IState nextState);
    }
}