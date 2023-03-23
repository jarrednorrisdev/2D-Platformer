using UnityEngine;

namespace Pawn.Controller2D.Dash
{
    [System.Serializable]
    public class PawnDashContext
    {
        [field: SerializeField]
        public PawnController2D ParentController { get; private set; }

        // [field: SerializeField]
        // public Collider2D Collider { get; private set; }
        //
        // [field: SerializeField]
        // public LayerMask GroundLayer { get; private set; }

        [field: SerializeField]
        public DashStyle DashStyle { get; private set; }

        [field: SerializeField]
        public Rigidbody2D Rb;

        public float DashCooldownTimer { get; set; }
        public float DashDurationTimer { get; set; }
    }
}
