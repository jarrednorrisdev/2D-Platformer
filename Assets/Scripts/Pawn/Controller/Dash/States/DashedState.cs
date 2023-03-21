using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(
    fileName = "State_Dashed",
    menuName = "StateSystem/Dash/States/Dashed"
)]
public class DashedState : State<PawnDashContext>
{
    public override void OnEnterState(PawnDashContext context)
    {
        Debug.Log("Dashing");

        switch (context.ParentController.ControllerInput.Move)
        {
            case > 0:
                Debug.Log("Dashing Right");
                context.Rb.AddForce(
                    Vector2.right * context.DashStyle.InitialDashForce,
                    ForceMode2D.Impulse
                );
                break;
            case < 0:
                Debug.Log("Dashing Left");
                context.Rb.AddForce(
                    Vector2.left * context.DashStyle.InitialDashForce,
                    ForceMode2D.Impulse
                );
                break;
        }
    }

    public override void OnExitState(PawnDashContext context)
    {
        context.DashCooldownTimer = context.DashStyle.DashCooldown;
    }

    public override void OnUpdate(PawnDashContext context)
    {
        context.DashCooldownTimer -= Time.deltaTime;
    }

    public override void OnLateUpdate(PawnDashContext context) { }

    public override void OnFixedUpdate(PawnDashContext context) { }
}
