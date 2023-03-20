using UnityEngine;

[CreateAssetMenu(
    fileName = "GroundedState",
    menuName = "StateSystem/Jump/States/GroundedState"
)]
public class GroundedState : ScriptableObject, IState<PawnJumpContext>
{
    public void OnEnterState(PawnJumpContext context)
    {
        context.JumpCooldownTimer = 0;
        context.CoyoteTimer = context.CoyoteTime;
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
    }
}