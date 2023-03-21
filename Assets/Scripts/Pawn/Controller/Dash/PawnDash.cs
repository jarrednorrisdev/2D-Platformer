using Sirenix.OdinInspector;
using UnityEngine;

[System.Serializable]
[RequireComponent(typeof(PawnController2D))]
public class PawnDash : MonoBehaviour, IStateMachineUser<PawnDashContext>
{
    [field: SerializeField]
    public PawnDashContext Context { get; private set; }

    [field: SerializeField]
    public StateMachineController<PawnDashContext> DashStateMachine
    {
        get;
        private set;
    }

    public void Initialize()
    {
        DashStateMachine.Initialize(Context);
    }

    public void OnUpdate()
    {
        DashStateMachine.OnUpdate(Context);
    }

    public void OnFixedUpdate()
    {
        DashStateMachine.OnFixedUpdate(Context);
        Context.Rb.velocityX = Mathf.MoveTowards(
            Context.Rb.velocityX,
            0,
            Context.DashStyle.DashDecayRate
        );
    }

    public void OnLateUpdate()
    {
        DashStateMachine.OnLateUpdate(Context);
    }
}
