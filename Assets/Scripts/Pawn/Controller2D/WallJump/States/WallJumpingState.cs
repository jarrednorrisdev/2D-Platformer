using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.WallJump.States
{
    [CreateAssetMenu(
        fileName = "State_WallJumping",
        menuName = "StateSystem/WallJump/States/WallJumping"
    )]
    public class WallJumpingState : State<WallJumpContext>
    {
        public override void OnEnterState(WallJumpContext context)
        {
            context.WallJumpDurationTimer = context.WallJumpStyle.WallJumpDuration;
            context.WallJumpCooldownTimer = context.WallJumpStyle.WallJumpCooldown;
            float initialForce = context.WallJumpStyle.InitialWallJumpForce;
            Vector2 direction = Utilities.Vector2Helper.GetVectorFromBearing(
                context.WallJumpStyle.WallJumpArcBearing
            );

            if (context.ParentController.BoxRaycaster.Left)
            {
                context.Rb.AddForce(direction * initialForce, ForceMode2D.Impulse);
            }
            else if (context.ParentController.BoxRaycaster.Right)
            {
                context.Rb.AddForce(-direction * initialForce, ForceMode2D.Impulse);
            }
        }

        public override void OnExitState(WallJumpContext context) { }

        public override void OnUpdate(WallJumpContext context)
        {
            context.WallJumpDurationTimer -= Time.deltaTime;
        }

        public override void OnLateUpdate(WallJumpContext context) { }

        public override void OnFixedUpdate(WallJumpContext context)
        {
            float deceleration =
                context.WallJumpStyle.WallJumpDeceleration * Time.deltaTime;
            context.Rb.velocity = Vector2.MoveTowards(
                context.Rb.velocity,
                Vector2.zero,
                deceleration
            );
        }
    }
}
