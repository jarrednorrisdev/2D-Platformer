using UnityEngine;

[CreateAssetMenu(
    fileName = "RisingState",
    menuName = "StateSystem/Jump/States/RisingState"
)]
public class RisingState : ScriptableObject, IState<PawnJumpContext>
{
    public void OnEnterState(PawnJumpContext context)
    {
        context.Rb.AddForce(
            Vector2.up * context.InitialJumpForce,
            ForceMode2D.Impulse
        );
    }

    public void OnExitState(PawnJumpContext context)
    {
        /* ... */
    }

    public void OnUpdate(PawnJumpContext context)
    {
        /* ... */
    }

    public void OnLateUpdate(PawnJumpContext context)
    {
        /* ... */
    }

    public void OnFixedUpdate(PawnJumpContext context)
    {
        /* ... */
        float additionalJumpForce =
            context.JumpForceIncreaseSpeed * Time.deltaTime;
        context.Rb.AddForce(
            Vector2.up * additionalJumpForce,
            ForceMode2D.Impulse
        );
        Vector2 velocity = context.Rb.velocity;
        context.Rb.velocity = new Vector2(
            velocity.x,
            Mathf.Clamp(velocity.y, 0, context.MaxJumpForce)
        );
    }
}