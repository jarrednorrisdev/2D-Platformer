using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(
    fileName = "State_Grounded",
    menuName = "StateSystem/Jump/States/Grounded"
)]
public class GroundedState : State<PawnJumpContext>
{
    public override void OnEnterState(PawnJumpContext context)
    {
        context.CoyoteTimer = context.JumpStyle.CoyoteTime;
    }

    public override void OnExitState(PawnJumpContext context) { }

    public override void OnUpdate(PawnJumpContext context)
    {
        context.JumpCooldownTimer -= Time.deltaTime;
    }

    public override void OnLateUpdate(PawnJumpContext context) { }

    public override void OnFixedUpdate(PawnJumpContext context) { }
}
