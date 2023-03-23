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
            context.Rb.velocityY = 0;
        }

        public override void OnExitState(WallJumpContext context) { }

        public override void OnUpdate(WallJumpContext context) { }

        public override void OnLateUpdate(WallJumpContext context) { }

        public override void OnFixedUpdate(WallJumpContext context)
        {
            context.Rb.AddForce(
                Vector2.up * context.WallJumpStyle.WallSlideSpeedMultiplier,
                ForceMode2D.Impulse
            );
        }
    }
}
