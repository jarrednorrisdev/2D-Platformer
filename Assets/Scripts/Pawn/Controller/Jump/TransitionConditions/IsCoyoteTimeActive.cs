using UnityEngine;

[CreateAssetMenu(
    fileName = "Condition_IsCoyoteTimeActive",
    menuName = "StateSystem/Jump/Conditions/IsCoyoteTimeActive"
)]
public class IsCoyoteTimeActive : TransitionCondition<PawnJumpContext>
{
    protected override bool EvaluateCondition(PawnJumpContext context)
    {
        return context.CoyoteTimer > 0;
    }
}
