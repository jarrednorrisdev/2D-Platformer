using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

// Represents a state transition between two states with a set of conditions.
public class StateTransition<T> : ScriptableObject
{
    public State<T> FromState;
    public State<T> ToState;

    [InfoBox(
        "At least one condition group must meet the specified logic criteria for the transition to occur."
    )]
    [SerializeField]
    List<TransitionConditionGroup<T>> conditionGroups;

    [SerializeField]
    [Tooltip(
        "Log info on the evaluation of the condition groups linked to this state"
    )]
    bool enableLogging;

    // Evaluates if the transition should occur based on the conditions.
    public bool ShouldTransition(T context)
    {
        bool result = conditionGroups.Any(
            conditionGroup => conditionGroup.Evaluate(context)
        );
        if (enableLogging)
        {
            Debug.Log($"[{name}] +conditionGroup evaluated to [{result}]");
        }
        return result;
    }

    // Represents a group of transition conditions.
    [System.Serializable]
    class TransitionConditionGroup<T>
    {
        [InfoBox(
            "Conditions in the group are evaluated based on the selected logic."
        )]
        [EnumToggleButtons]
        [SerializeField]
        ConditionLogic logic;

        [SerializeField]
        List<TransitionCondition<T>> conditions;

        // Evaluates the conditions in the group based on the selected logic.
        public bool Evaluate(T context)
        {
            return logic switch
            {
                ConditionLogic.AND
                    => conditions.TrueForAll(
                        condition => condition.Evaluate(context)
                    ),
                ConditionLogic.OR
                    => conditions.Any(condition => condition.Evaluate(context)),
                ConditionLogic.XOR
                    => conditions.Count(
                        condition => condition.Evaluate(context)
                    ) == 1,
                _ => false
            };
        }
    }

    public enum ConditionLogic
    {
        AND,
        OR,
        XOR
    }
}
