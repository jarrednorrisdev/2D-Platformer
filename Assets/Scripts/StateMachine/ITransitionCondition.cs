using UnityEngine;

public interface ITransitionCondition<in T> 
{
    public bool Evaluate(T context);
}