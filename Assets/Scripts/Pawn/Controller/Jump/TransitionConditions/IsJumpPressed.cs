using UnityEngine;

[CreateAssetMenu(
    fileName = "Condition_IsJumpPressed",
    menuName = "StateSystem/Jump/Conditions/IsJumpPressed"
)]
public class IsJumpPressed : TransitionCondition<PawnJumpContext>
{
    protected override bool EvaluateCondition(PawnJumpContext context)
    {
        return context.ParentController.ControllerInput.JumpPressed;
    }
}
