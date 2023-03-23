using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.Jump.Conditions
{
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
    }
}
