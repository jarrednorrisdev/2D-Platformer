using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.WallJump.Conditions
{
    [CreateAssetMenu(
        fileName = "Condition_IsWallJumpFinished",
        menuName = "StateSystem/WallJump/Conditions/IsWallJumpFinished"
    )]
    public class IsWallJumpFinished : TransitionCondition<WallJumpContext>
    {
        protected override bool EvaluateCondition(WallJumpContext context)
        {
            return context.WallJumpDurationTimer <= 0;
        }
    }
}
