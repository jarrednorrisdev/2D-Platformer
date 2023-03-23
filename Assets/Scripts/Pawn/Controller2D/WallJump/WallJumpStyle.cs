using UnityEngine;

namespace Pawn.Controller2D.WallJump
{
    [CreateAssetMenu(fileName = "WallJumpStyle_", menuName = "BehaviourStyles/WallJumpStyle")]
    public class WallJumpStyle : ScriptableObject
    {
        [field: SerializeField]
        public float WallJumpCooldown { get; private set; } = 0.1f;

        [field: SerializeField]
        public float InitialWallJumpForce { get; private set; } = 10f;

        [field: SerializeField]
        public float WallSlideSpeedMultiplier { get; private set; } = 0.5f;

        [field: SerializeField]
        public float WallJumpDeceleration { get; private set; } = 2.0f;

        [field: SerializeField]
        public float WallJumpDecayRate { get; private set; } = 2.0f;

        [field: SerializeField]
        public float WallJumpDuration { get; private set; } = 2.0f;

        [field: SerializeField]
        [field: Range(0, 180)]
        public float WallJumpArcBearing { get; private set; } = 2.0f;
    }
}
