using UnityEngine;

namespace StateMachine
{
    public abstract class State<T> : ScriptableObject
    {
        public abstract void OnEnterState(T context);
        public abstract void OnExitState(T context);
        public abstract void OnUpdate(T context);
        public abstract void OnFixedUpdate(T context);
        public abstract void OnLateUpdate(T context);
    }
}
