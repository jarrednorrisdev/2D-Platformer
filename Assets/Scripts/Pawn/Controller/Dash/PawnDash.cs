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
    }

    public void OnLateUpdate()
    {
        DashStateMachine.OnLateUpdate(Context);
    }
}
