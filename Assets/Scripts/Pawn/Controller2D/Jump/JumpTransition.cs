using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.Jump
{
    [CreateAssetMenu(
        fileName = "Transition",
        menuName = "StateSystem/Jump/Transition"
    )]
    public class JumpStateTransition
        : StateTransition<PawnJumpContext> { }
}
