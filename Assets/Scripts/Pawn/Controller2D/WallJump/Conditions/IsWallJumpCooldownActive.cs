using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.WallJump.Conditions
{
    [CreateAssetMenu(
        fileName = "Condition_IsWallJumpCooldownActive",
        menuName = "StateSystem/WallJump/Conditions/IsWallJumpCooldownActive"
    )]
    public class IsWallJumpCooldownActive : TransitionCondition<WallJumpContext>
    {
        protected override bool EvaluateCondition(WallJumpContext context)
        {
            return context.WallJumpCooldownTimer > 0;
        }
    }
}
