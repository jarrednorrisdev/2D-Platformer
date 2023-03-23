using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.WallJump.States
{
    [CreateAssetMenu(
        fileName = "State_Sliding",
        menuName = "StateSystem/WallJump/States/Sliding"
    )]
    public class SlidingState : State<WallJumpContext>
    {
        float _cachedGravityScale;

        public override void OnEnterState(WallJumpContext context)
        {
            float gravityScale = context.Rb.gravityScale;
            _cachedGravityScale = gravityScale;
            gravityScale *= context.WallJumpStyle.WallSlideSpeedMultiplier;
            context.Rb.gravityScale = gravityScale;
        }

        public override void OnExitState(WallJumpContext context)
        {
            context.Rb.gravityScale = _cachedGravityScale;
        }

        public override void OnUpdate(WallJumpContext context) { }

        public override void OnLateUpdate(WallJumpContext context) { }

        public override void OnFixedUpdate(WallJumpContext context) { }
    }
}
