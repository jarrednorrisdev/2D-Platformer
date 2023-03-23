using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.WallJump
{
    [System.Serializable]
    [RequireComponent(typeof(PawnController2D))]
    public class PawnWallJump : MonoBehaviour, IStateMachineUser<WallJumpContext>
    {
        [field: SerializeField]
        public WallJumpContext Context { get; private set; }

        [field: SerializeField]
        public StateMachineController<WallJumpContext> JumpStateMachine
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
}