using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.Jump.States
{
    [CreateAssetMenu(
        fileName = "State_Jumping",
        menuName = "StateSystem/Jump/States/Jumping"
    )]
    public class JumpingState : State<PawnJumpContext>
    {
        public override void OnEnterState(PawnJumpContext context)
        {
            context.JumpCooldownTimer = context.JumpStyle.JumpCooldown;
            context.Rb.velocityY = 0;
            context.Rb.AddForce(
                Vector2.up * context.JumpStyle.InitialJumpForce,
                ForceMode2D.Impulse
            );
        }

        public override void OnExitState(PawnJumpContext context) { }

        public override void OnUpdate(PawnJumpContext context)
        {
            context.CoyoteTimer -= Time.deltaTime;
            context.JumpCooldownTimer -= Time.deltaTime;
        }

        public override void OnLateUpdate(PawnJumpContext context) { }

        public override void OnFixedUpdate(PawnJumpContext context)
        {
            float additionalJumpForce =
                context.JumpStyle.JumpForceIncreaseSpeed * Time.deltaTime;
            context.Rb.AddForce(
                Vector2.up * additionalJumpForce,
                ForceMode2D.Impulse
            );

            Vector2 velocity = context.Rb.velocity;
            context.Rb.velocity = new Vector2(
                velocity.x,
                Mathf.Clamp(
                    velocity.y,
                    0,
                    context.JumpStyle.MaxJumpForce
                )
            );
        }
    }
}
