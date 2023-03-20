using UnityEngine;

[CreateAssetMenu(
    fileName = "IsTerminatingJumpCondition",
    menuName = "StateSystem/Jump/Transitions/IsTerminatingJumpCondition"
)]
public class IsTerminatingJump : ScriptableObject, ITransitionCondition<PawnJumpContext>
{
    public bool Evaluate(PawnJumpContext context)
    {
        return context.ParentController.ControllerInput.JumpReleased;
    }
}