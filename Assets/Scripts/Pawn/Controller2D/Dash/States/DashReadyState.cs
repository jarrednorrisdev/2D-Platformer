using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.Dash.States
{
    [CreateAssetMenu(
        fileName = "State_DashReady",
        menuName = "StateSystem/Dash/States/DashReady"
    )]
    public class DashReadyState : State<PawnDashContext>
    {
        public override void OnEnterState(PawnDashContext context) { }

        public override void OnExitState(PawnDashContext context) { }

        public override void OnUpdate(PawnDashContext context)
        {
            if (context.DashCooldownTimer > 0)
            {
                context.DashCooldownTimer -= Time.deltaTime;
            }
        }

        public override void OnLateUpdate(PawnDashContext context) { }

        public override void OnFixedUpdate(PawnDashContext context) { }
    }
}
