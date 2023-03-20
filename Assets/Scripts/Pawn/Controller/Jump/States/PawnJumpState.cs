using UnityEngine;

public abstract class PawnJumpState
    : ScriptableObject,
        IState<PawnJumpContext>
{
    public abstract void OnEnterState(PawnJumpContext context);

    public abstract void OnExitState(PawnJumpContext context);

    public abstract void OnUpdate(PawnJumpContext context);

    public abstract void OnFixedUpdate(PawnJumpContext context);

    public abstract void OnLateUpdate(PawnJumpContext context);
}
