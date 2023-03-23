using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.Jump.Conditions
{
    [CreateAssetMenu(
        fileName = "Condition_IsGrounded",
        menuName = "StateSystem/Jump/Conditions/IsGrounded"
    )]
    public class IsGrounded : TransitionCondition<PawnJumpContext>
    {
        protected override bool EvaluateCondition(PawnJumpContext context)
        {
            return context.ParentController.BoxRaycaster.Bottom;
        }
    }
}
