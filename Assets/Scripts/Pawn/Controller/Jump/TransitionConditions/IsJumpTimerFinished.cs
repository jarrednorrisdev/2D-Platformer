using UnityEngine;

[CreateAssetMenu(
    fileName = "Condition_IsJumpTimerFinished",
    menuName = "StateSystem/Jump/Conditions/IsJumpTimerFinished"
)]
public class IsJumpTimerFinished : TransitionCondition<PawnJumpContext>
{
    protected override bool EvaluateCondition(PawnJumpContext context)
    {
        return context.JumpCooldownTimer <= 0;
    }

    public IsJumpTimerFinished()
    {
        ConditionDisplayString = @"return context.JumpCooldownTimer <= 0;";
    }
}
