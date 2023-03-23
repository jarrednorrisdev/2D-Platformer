using UnityEngine;

// Represents an individual transition condition.
namespace StateMachine
{
    [System.Serializable]
    public abstract class TransitionCondition<T> : ScriptableObject
    {
        [SerializeField]
        [Tooltip("Negate the evaluation result of this condition.")]
        bool negate;

        [SerializeField]
        [Tooltip("Log info on the evaluation of this condition")]
        bool enableLogging;

        // Evaluates the condition based on the context.
        public bool Evaluate(T context)
        {
            bool result = EvaluateCondition(context);
            if (enableLogging)
            {
                if (negate)
                {
                    Debug.Log($"[{name}] -condition evaluated to [{!result}]");
                }
                else
                {
                    Debug.Log($"[{name}] +condition evaluated to [{result}]");
                }
            }

            return negate ? !result : result;
        }

        // Implement this method in derived classes to provide the actual condition evaluation logic.
        protected abstract bool EvaluateCondition(T context);
    }
}
