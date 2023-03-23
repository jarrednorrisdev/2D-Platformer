using UnityEngine;

namespace Pawn.Controller2D.Dash
{
    [CreateAssetMenu(fileName = "DashStyle_", menuName = "BehaviourStyles/DashStyle")]
    public class DashStyle : ScriptableObject
    {
        [field: SerializeField]
        public float DashCooldown { get; private set; } = 0.1f;

        [field: SerializeField]
        public float InitialDashForce { get; private set; } = 5.0f;

        [field: SerializeField]
        public float DashDeceleration { get; private set; } = 2.0f;
    
        [field: SerializeField]
        public float DashDecayRate { get; private set; } = 2.0f;
    
        [field: SerializeField]
        public float DashDuration { get; private set; } = 2.0f;
    
    }
}
