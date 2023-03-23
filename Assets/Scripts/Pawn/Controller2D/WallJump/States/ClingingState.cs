using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.WallJump.States
{
    [CreateAssetMenu(
        fileName = "State_Clinging",
        menuName = "StateSystem/WallJump/States/Clinging"
    )]
    public class ClingingState : State<WallJumpContext>
    {
        float _cachedGravityScale;

        public override void OnEnterState(WallJumpContext context)
        {
            _cachedGravityScale = context.Rb.gravityScale;
            context.Rb.gravityScale = 0;
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
