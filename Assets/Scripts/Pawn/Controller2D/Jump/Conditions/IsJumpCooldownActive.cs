using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.Jump.Conditions
{
    [CreateAssetMenu(
        fileName = "Condition_IsJumpCooldownActive",
        menuName = "StateSystem/Jump/Conditions/IsJumpCooldownActive"
    )]
    public class IsJumpCooldownActive : TransitionCondition<PawnJumpContext>
    {
        protected override bool EvaluateCondition(PawnJumpContext context)
        {
            return context.JumpCooldownTimer > 0;
        }
    }
}
