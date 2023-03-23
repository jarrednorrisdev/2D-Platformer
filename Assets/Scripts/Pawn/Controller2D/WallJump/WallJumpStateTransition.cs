using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.WallJump
{
    [CreateAssetMenu(
        fileName = "Transition",
        menuName = "StateSystem/WallJump/Transition"
    )]
    public class WallJumpStateTransition : StateTransition<WallJumpContext> { }
}
