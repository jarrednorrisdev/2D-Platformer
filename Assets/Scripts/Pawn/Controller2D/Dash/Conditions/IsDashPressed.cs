using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.Dash.Conditions
{
    [CreateAssetMenu(
        fileName = "Condition_IsDashPressed",
        menuName = "StateSystem/Dash/Conditions/IsDashPressed"
    )]
    public class IsDashPressed : TransitionCondition<PawnDashContext>
    {
        protected override bool EvaluateCondition(PawnDashContext context)
        {
            return context.ParentController.ControllerInput.Dash;
        }
    }
}
