﻿using Sirenix.OdinInspector;
using UnityEngine;

// Represents an individual transition condition.
[System.Serializable]
public abstract class TransitionCondition<T> : ScriptableObject
{
    [SerializeField]
    [Tooltip("Negate the evaluation result of this condition.")]
    bool negate;

    // Evaluates the condition based on the context.
    public bool Evaluate(T context)
    {
        bool result = EvaluateCondition(context);
        return negate ? !result : result;
    }
    

    // Implement this method in derived classes to provide the actual condition evaluation logic.
    protected abstract bool EvaluateCondition(T context);

    [InfoBox(
        "This is merely a copy paste of the code for quick reference. "
            + "If something is not as expected, "
            + "double check the actual implementation matches "
            + "the code displayed here"
    )]
    [TextArea(4, 20)]
    [SerializeField]
    [ReadOnly]
    protected string ConditionDisplayString =
        "Lazy coder didnt copy the code for you";
    
    
}