using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.WallJump.Conditions
{
    [CreateAssetMenu(
        fileName = "Condition_IsJumpPressed",
        menuName = "StateSystem/WallJump/Conditions/IsJumpPressed"
    )]
    public class IsJumpPressed : TransitionCondition<WallJumpContext>
    {
        protected override bool EvaluateCondition(WallJumpContext context)
        {
            return context.ParentController.ControllerInput.JumpPressed;
        }
    }
}
