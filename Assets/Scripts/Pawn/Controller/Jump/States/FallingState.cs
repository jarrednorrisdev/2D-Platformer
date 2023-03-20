using UnityEngine;

[CreateAssetMenu(
    fileName = "FallingState",
    menuName = "StateSystem/Jump/States/FallingState"
)]
public class FallingState : ScriptableObject, IState<PawnJumpContext>
{
    public void OnEnterState(PawnJumpContext pawnJump)
    {
        pawnJump.JumpCooldown = 0;
        pawnJump.Rb.velocity = new Vector2(pawnJump.Rb.velocity.x, 0);
    }

    public void OnExitState(PawnJumpContext pawnJump) { /* ... */
    }

    public void OnUpdate(PawnJumpContext pawnJump) { /* ... */
    }

    public void OnLateUpdate(PawnJumpContext pawnJump) { /* ... */
    }

    public void OnFixedUpdate(PawnJumpContext pawnJump) { /* ... */
    }
}
