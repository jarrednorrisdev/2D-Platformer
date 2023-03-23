using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.WallJump.Conditions
{
    [CreateAssetMenu(
        fileName = "Condition_IsJumpReleased",
        menuName = "StateSystem/WallJump/Conditions/IsJumpReleased"
    )]
    public class IsJumpReleased : TransitionCondition<WallJumpContext>
    {
        protected override bool EvaluateCondition(WallJumpContext context)
        {
            return context.ParentController.ControllerInput.JumpReleased;
        }
    }
}
