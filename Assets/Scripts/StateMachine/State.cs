using Sirenix.OdinInspector;
using UnityEngine;

public abstract class State<T> : SerializedScriptableObject
{
    public abstract void OnEnterState(T context);
    public abstract void OnExitState(T context);
    public abstract void OnUpdate(T context);
    public abstract void OnFixedUpdate(T context);
    public abstract void OnLateUpdate(T context);
}