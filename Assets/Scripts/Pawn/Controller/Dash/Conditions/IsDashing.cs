﻿using UnityEngine;

[CreateAssetMenu(
    fileName = "Condition_IsDashing",
    menuName = "StateSystem/Dash/Conditions/IsDashing"
)]
public class IsDashing : TransitionCondition<PawnDashContext>
{
    protected override bool EvaluateCondition(PawnDashContext context)
    {
        return context.DashDurationTimer > 0;
    }
}
