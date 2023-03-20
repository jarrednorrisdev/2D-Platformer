using UnityEngine;

public interface IState<in T>
{
    public void OnEnterState(T context);
    public void OnExitState(T context);
    public void OnUpdate(T context);
    public void OnFixedUpdate(T context);
    public void OnLateUpdate(T context);
}