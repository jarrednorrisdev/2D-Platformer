using UnityEngine;

public class StateTransition<T> : ScriptableObject
{
    public IState<T> FromState;

    public IState<T> ToState;

    public ITransitionCondition<T> Condition;

    public bool ShouldTransition(T context)
    {
        return Condition.Evaluate(context);
    }
}
