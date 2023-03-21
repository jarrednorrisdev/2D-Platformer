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
        context.JumpCooldownTimer = context.JumpStyle.JumpCooldown;
        context.CoyoteTimer = context.JumpStyle.CoyoteTime;
    }

    public override void OnExitState(PawnJumpContext context) { }

    public override void OnUpdate(PawnJumpContext context) { }

    public override void OnLateUpdate(PawnJumpContext context) { }

    public override void OnFixedUpdate(PawnJumpContext context) { }
}
