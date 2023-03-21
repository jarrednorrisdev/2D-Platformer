using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(
    fileName = "State_Dashing",
    menuName = "StateSystem/Dash/States/Dashing"
)]
public class DashingState : State<PawnDashContext>
{
    public override void OnEnterState(PawnDashContext context)
    {
        Debug.Log("Dashing");

        context.DashDurationTimer = context.DashStyle.DashDuration;

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
        context.DashDurationTimer = 0f;
    }

    public override void OnUpdate(PawnDashContext context)
    {
        context.DashDurationTimer -= Time.deltaTime;
    }

    public override void OnLateUpdate(PawnDashContext context) { }

    public override void OnFixedUpdate(PawnDashContext context)
    {
        float deceleration =
            context.DashStyle.DashDeceleration * Time.deltaTime;
        context.Rb.velocity = Vector2.MoveTowards(
            context.Rb.velocity,
            Vector2.zero,
            deceleration
        );
    }
}
