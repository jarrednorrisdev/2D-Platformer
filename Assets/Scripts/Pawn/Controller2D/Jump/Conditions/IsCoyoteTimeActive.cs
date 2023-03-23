using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.Jump.Conditions
{
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
}
