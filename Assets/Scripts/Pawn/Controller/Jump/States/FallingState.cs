using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(
    fileName = "State_Falling",
    menuName = "StateSystem/Jump/States/Falling"
)]
public class FallingState : State<PawnJumpContext>
{
    public override void OnEnterState(PawnJumpContext context)
    {
        //context.Rb.velocity = new Vector2(context.Rb.velocity.x, 0);
    }

    public override void OnExitState(PawnJumpContext context) { }

    public override void OnUpdate(PawnJumpContext context)
    {
        context.JumpCooldownTimer -= Time.deltaTime;
    }

    public override void OnLateUpdate(PawnJumpContext context) { }

    public override void OnFixedUpdate(PawnJumpContext context) { }
}
