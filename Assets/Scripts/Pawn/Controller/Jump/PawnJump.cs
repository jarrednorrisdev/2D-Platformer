﻿using UnityEngine;

[System.Serializable]
public class PawnJump
    : MonoBehaviour,
        IStateMachineUser<PawnJumpContext>
{
    [field: SerializeField]
    public PawnJumpContext Context { get; private set; }

    [field: SerializeField]
    public StateMachineController<PawnJumpContext> JumpStateMachine
    {
        get;
        private set;
    }

    public void Initialize()
    {
        JumpStateMachine.Initialize(Context);
    }

    public void OnUpdate()
    {
        JumpStateMachine.OnUpdate(Context);
    }

    public void OnFixedUpdate()
    {
        JumpStateMachine.OnFixedUpdate(Context);
    }

    public void OnLateUpdate()
    {
        JumpStateMachine.OnLateUpdate(Context);
    }
}
