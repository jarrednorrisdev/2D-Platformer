
using UnityEngine;

[CreateAssetMenu(
    fileName = "IsGroundedCondition",
    menuName = "StateSystem/Jump/Transitions/IsGroundedCondition"
)]
public class IsGrounded : ScriptableObject, ITransitionCondition<PawnJumpContext>
{
    public bool Evaluate(PawnJumpContext context)
    {
        return Physics2D.OverlapCircle(
            context.GroundCheck.position,
            context.GroundCheckRadius,
            context.GroundLayer
        );
    }
}
