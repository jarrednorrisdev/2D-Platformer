using UnityEngine;

[CreateAssetMenu(
    fileName = "IsStartingJumpCondition",
    menuName = "StateSystem/Jump/Transitions/IsStartingJumpCondition"
)]
public class IsStartingJump : ScriptableObject, ITransitionCondition<PawnJumpContext>
{
    public bool Evaluate(PawnJumpContext context)
    {
        return context.ParentController.ControllerInput.JumpPressed;
    }
}
