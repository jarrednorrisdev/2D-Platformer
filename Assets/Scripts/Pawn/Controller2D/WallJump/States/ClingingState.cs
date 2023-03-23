using StateMachine;
using UnityEngine;

namespace Pawn.Controller2D.WallJump.States
{
    [CreateAssetMenu(
        fileName = "State_Clinging",
        menuName = "StateSystem/WallJump/States/Clinging"
    )]
    public class ClingingState : State<WallJumpContext>
    {
        

        public override void OnEnterState(WallJumpContext context)
        {
            
        }

        public override void OnExitState(WallJumpContext context)
        {
            
        }

        public override void OnUpdate(WallJumpContext context) { }

        public override void OnLateUpdate(WallJumpContext context) { }

        public override void OnFixedUpdate(WallJumpContext context) { }
    }
}
