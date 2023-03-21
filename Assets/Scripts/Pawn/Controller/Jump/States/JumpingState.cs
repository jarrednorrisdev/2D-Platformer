using UnityEngine;

[CreateAssetMenu(
    fileName = "State_Jumping",
    menuName = "StateSystem/Jump/States/Jumping"
)]
public class JumpingState : State<PawnJumpContext>
{
    public override void OnEnterState(PawnJumpContext context)
    {
        context.Rb.AddForce(
            Vector2.up * context.JumpStyle.InitialJumpForce,
            ForceMode2D.Impulse
        );
    }

    public override void OnExitState(PawnJumpContext context) { }

    public override void OnUpdate(PawnJumpContext context) { }

    public override void OnLateUpdate(PawnJumpContext context) { }

    public override void OnFixedUpdate(PawnJumpContext context)
    {
        float additionalJumpForce =
            context.JumpStyle.JumpForceIncreaseSpeed * Time.deltaTime;
        context.Rb.AddForce(
            Vector2.up * additionalJumpForce,
            ForceMode2D.Impulse
        );

        context.Rb.velocity = new Vector2(
            context.Rb.velocity.x,
            Mathf.Clamp(
                context.Rb.velocity.y,
                0,
                context.JumpStyle.MaxJumpForce
            )
        );
    }
}
