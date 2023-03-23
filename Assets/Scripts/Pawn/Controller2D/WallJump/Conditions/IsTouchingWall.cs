using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.WallJump.Conditions
{
    [CreateAssetMenu(
        fileName = "Condition_IsTouchingWall",
        menuName = "StateSystem/WallJump/Conditions/IsTouchingWall"
    )]
    public class IsTouchingWall : TransitionCondition<WallJumpContext>
    {
        protected override bool EvaluateCondition(WallJumpContext context)
        {
            return context.ParentController.BoxRaycaster.Left
                || context.ParentController.BoxRaycaster.Right;
        }
    }
}
