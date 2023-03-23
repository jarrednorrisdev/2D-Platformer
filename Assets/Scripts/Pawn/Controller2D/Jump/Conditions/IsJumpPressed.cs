using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.Jump.Conditions
{
    [CreateAssetMenu(
        fileName = "Condition_IsJumpPressed",
        menuName = "StateSystem/Jump/Conditions/IsJumpPressed"
    )]
    public class IsJumpPressed : TransitionCondition<PawnJumpContext>
    {
        protected override bool EvaluateCondition(PawnJumpContext context)
        {
            return context.ParentController.ControllerInput.JumpPressed;
        }
    }
}
