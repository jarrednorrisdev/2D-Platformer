using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.Dash
{
    [CreateAssetMenu(
        fileName = "Transition",
        menuName = "StateSystem/Dash/Transition"
    )]
    public class DashStateTransition : StateTransition<PawnDashContext> { }
}
