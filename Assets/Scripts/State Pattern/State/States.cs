using UnityEngine;

namespace StatePattern
{
    public class StateA : IState
    {
        public void Enter() => Debug.Log("State A: Enter");
        public void Execute_A() => Debug.Log("State A: Execute A");
        public void Execute_B() => Debug.Log("State A: Execute B");
        public void Exit() => Debug.Log("State A: Exit");
    }

    public class StateB : IState
    {
        public void Enter() => Debug.Log("State B: Enter");
        public void Execute_A() => Debug.Log("State B: Execute A");
        public void Execute_B() { }
        public void Exit() => Debug.Log("State B: Exit");
    }
}