namespace StateMachine
{
    public interface IStateMachineUser<out T>
    {
        public T Context { get; }
        public void Initialize();
        public void OnUpdate();
        public void OnFixedUpdate();
        public void OnLateUpdate();
    }
}
