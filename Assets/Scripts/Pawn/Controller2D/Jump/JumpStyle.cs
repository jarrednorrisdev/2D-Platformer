using UnityEngine;

namespace Pawn.Controller2D.Jump
{
    [CreateAssetMenu(fileName = "JumpStyle_", menuName = "BehaviourStyles/JumpStyle")]
    public class JumpStyle : ScriptableObject
    {
        [field: SerializeField]
        public float JumpCooldown { get; private set; } = 0.1f;

        [field: SerializeField]
        public float CoyoteTime { get; private set; } = 0.1f;

        [field: SerializeField]
        public float InitialJumpForce { get; private set; } = 5.0f;

        [field: SerializeField]
        public float MaxJumpForce { get; private set; } = 10.0f;

        [field: SerializeField]
        public float JumpForceIncreaseSpeed { get; private set; } = 5.0f;
    }
}
