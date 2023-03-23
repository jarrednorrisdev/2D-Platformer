using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace StateMachine
{
    [System.Serializable]
    public class StateMachineController<T>
    {
        [field: SerializeField]
        State<T> InitialState { get; set; }

        [field: SerializeField]
        public List<StateTransition<T>> Transitions { get; set; }

        [field: SerializeField]
        bool LogTransitions { get; set; }

        State<T> CurrentState { get; set; }

        public void Initialize(T context)
        {
            SetState(context, InitialState);
            CurrentState.OnEnterState(context);
        }

        public void OnUpdate(T context)
        {
            CurrentState.OnUpdate(context);

            foreach (
                StateTransition<T> transition in Transitions.Where(
                    transition =>
                        CurrentState == transition.FromState
                        && transition.ShouldTransition(context)
                )
            )
            {
                SetState(context, transition.ToState);
                break;
            }
        }

        public void OnFixedUpdate(T context)
        {
            CurrentState.OnFixedUpdate(context);
        }

        public void OnLateUpdate(T context)
        {
            CurrentState.OnLateUpdate(context);
        }

        public void SetState(T context, State<T> newState)
        {
            if (CurrentState != null)
            {
                if (LogTransitions)
                {
                    Debug.Log(
                        $"Transitioning From {CurrentState.name} to {newState.name}"
                    );
                }
                CurrentState.OnExitState(context);
            }
            else
            {
                if (LogTransitions)
                {
                    Debug.Log($"Transitioning From NO STATE to {newState.name}");
                }
            }
            CurrentState = newState;
            CurrentState.OnEnterState(context);
        }
    }
}
