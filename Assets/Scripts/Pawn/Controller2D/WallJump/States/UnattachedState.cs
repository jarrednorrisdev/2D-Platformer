using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.WallJump.States
{
    [CreateAssetMenu(
        fileName = "State_Unattached",
        menuName = "StateSystem/WallJump/States/Unattached"
    )]
    public class UnattachedState : State<WallJumpContext>
    {
        public override void OnEnterState(WallJumpContext context) { }

        public override void OnExitState(WallJumpContext context) { }

        public override void OnUpdate(WallJumpContext context)
        {
            context.WallJumpCooldownTimer -= Time.deltaTime;
        }

        public override void OnLateUpdate(WallJumpContext context) { }

        public override void OnFixedUpdate(WallJumpContext context) { }
    }
}
