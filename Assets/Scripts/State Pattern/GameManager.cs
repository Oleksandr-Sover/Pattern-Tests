using UnityEngine;

namespace StatePattern
{
    public class GameManager : MonoBehaviour
    {
        IStateInitializer StateInitializer = new StateInitializer();
        IState CurrentState;

        StateA stateA = new StateA();
        StateB stateB = new StateB();

        void Start()
        {
            CurrentState = StateInitializer.NewState(stateA);
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                CurrentState = StateInitializer.ChangeState(CurrentState, stateA);
                CurrentState.Execute_A();
                CurrentState.Execute_B();
            }
            if (Input.GetMouseButtonDown(1))
            {
                CurrentState = StateInitializer.ChangeState(CurrentState, stateB);
                CurrentState.Execute_A();
                CurrentState.Execute_B();
            }
        }
    }
}