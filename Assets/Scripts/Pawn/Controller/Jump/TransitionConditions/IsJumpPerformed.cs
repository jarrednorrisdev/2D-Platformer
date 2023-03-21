using UnityEngine;

[CreateAssetMenu(
    fileName = "Condition_IsJumpPerformed",
    menuName = "StateSystem/Jump/Conditions/IsJumpPerformed"
)]
public class IsJumpPerformed : TransitionCondition<PawnJumpContext>
{
    protected override bool EvaluateCondition(PawnJumpContext context)
    {
        return context.ParentController.ControllerInput.JumpPerformed;
    }

    public IsJumpPerformed()
    {
        ConditionDisplayString =
            @"return context.ParentController.ControllerInput.JumpPerformed;";
    }
}
