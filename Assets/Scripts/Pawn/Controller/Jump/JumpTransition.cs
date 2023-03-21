using UnityEngine;

[CreateAssetMenu(
    fileName = "Transition",
    menuName = "StateSystem/Jump/Transition"
)]
public class JumpStateTransition
    : StateTransition<PawnJumpContext> { }
