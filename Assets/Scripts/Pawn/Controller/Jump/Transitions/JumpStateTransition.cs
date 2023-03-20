using UnityEngine;

[CreateAssetMenu(
    fileName = "Transition",
    menuName = "StateSystem/Transition"
)]
public class JumpStateTransition : ScriptableObject
{
    [SerializeField]
    public IState<PawnJumpContext> FromState;

    [SerializeField]
    public IState<PawnJumpContext> ToState;

    [SerializeField]
    public ITransitionCondition<PawnJumpContext> Condition;

    public bool ShouldTransition(PawnJumpContext context)
    {
        return Condition.Evaluate(context);
    }
}
