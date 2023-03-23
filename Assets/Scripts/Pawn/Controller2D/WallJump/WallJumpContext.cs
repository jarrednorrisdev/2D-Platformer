using Pawn.Controller2D.Dash;
using Pawn.Controller2D.Jump;
using UnityEngine;

namespace Pawn.Controller2D.WallJump
{
    [System.Serializable]
    public class WallJumpContext
    {
        [field: SerializeField]
        public PawnController2D ParentController { get; private set; }

        [field: SerializeField]
        public LayerMask CollisionMask { get; private set; }

        [field: SerializeField]
        public WallJumpStyle WallJumpStyle { get; private set; }

        [field: SerializeField]
        public Rigidbody2D Rb { get; private set; }

        [field: SerializeField]
        public Collider2D Collider { get; private set; }
        
        

        public float WallJumpCooldownTimer { get; set; }
        public float WallJumpDurationTimer { get; set; }
    }
}
