using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(
    fileName = "State_DashOnCooldown",
    menuName = "StateSystem/Dash/States/DashOnCooldown"
)]
public class DashOnCooldownState : State<PawnDashContext>
{
    public override void OnEnterState(PawnDashContext context)
    {
        context.DashCooldownTimer = context.DashStyle.DashCooldown;
    }

    public override void OnExitState(PawnDashContext context) { }

    public override void OnUpdate(PawnDashContext context)
    {
        context.DashCooldownTimer -= Time.deltaTime;
    }

    public override void OnLateUpdate(PawnDashContext context) { }

    public override void OnFixedUpdate(PawnDashContext context) { }
}
