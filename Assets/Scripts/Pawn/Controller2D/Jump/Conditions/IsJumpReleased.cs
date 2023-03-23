using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.Jump.Conditions
{
    [CreateAssetMenu(
        fileName = "Condition_IsJumpReleased",
        menuName = "StateSystem/Jump/Conditions/IsJumpReleased"
    )]
    public class IsJumpReleased : TransitionCondition<PawnJumpContext>
    {
        protected override bool EvaluateCondition(PawnJumpContext context)
        {
            return context.ParentController.ControllerInput.JumpReleased;
        }
    }
}
