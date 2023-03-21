using UnityEngine;

[CreateAssetMenu(
    fileName = "Condition_IsJumpReleased",
    menuName = "StateSystem/Jump/Conditions/IsJumpReleased"
)]
public class IsJumpReleased : TransitionCondition<PawnJumpContext>
{
    protected override bool EvaluateCondition(PawnJumpContext context)
    {
        return context.ParentController.ControllerInput.JumpReleased;
    }

    public IsJumpReleased()
    {
        ConditionDisplayString =
            @"return context.ParentController.ControllerInput.JumpReleased;";
    }
}
