using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(
    fileName = "State_DashReady",
    menuName = "StateSystem/Dash/States/DashReady"
)]
public class DashReadyState : State<PawnDashContext>
{
    public override void OnEnterState(PawnDashContext context) { }

    public override void OnExitState(PawnDashContext context)
    {
        context.DashCooldownTimer = context.DashStyle.DashCooldown;
    }

    public override void OnUpdate(PawnDashContext context) { }

    public override void OnLateUpdate(PawnDashContext context) { }

    public override void OnFixedUpdate(PawnDashContext context) { }
}
