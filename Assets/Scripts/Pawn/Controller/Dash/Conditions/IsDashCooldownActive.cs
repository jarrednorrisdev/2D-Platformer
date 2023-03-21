using UnityEngine;

[CreateAssetMenu(
    fileName = "Condition_IsDashCooldownActive",
    menuName = "StateSystem/Dash/Conditions/IsDashCooldownActive"
)]
public class IsDashCooldownActive : TransitionCondition<PawnDashContext>
{
    protected override bool EvaluateCondition(PawnDashContext context)
    {
        return context.DashCooldownTimer > 0;
    }
}
