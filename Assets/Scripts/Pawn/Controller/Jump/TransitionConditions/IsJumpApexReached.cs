using UnityEngine;

[CreateAssetMenu(
    fileName = "Condition_IsJumpApexReached",
    menuName = "StateSystem/Jump/Conditions/IsJumpApexReached"
)]
public class IsJumpApexReached : TransitionCondition<PawnJumpContext>
{
    protected override bool EvaluateCondition(PawnJumpContext context)
    {
        return context.Rb.velocity.y <= 0;
    }

    public IsJumpApexReached()
    {
        ConditionDisplayString = @"return context.Rb.velocity.y <= 0;";
    }
}
