using UnityEngine;

namespace Pawn.Controller2D.Move
{
    [CreateAssetMenu(fileName = "MoveStyle_", menuName = "BehaviourStyles/MoveStyle")]
    public class MoveStyle : ScriptableObject
    {
        [field: SerializeField]
        public float Speed { get; private set; }

        [field: SerializeField]
        public float Acceleration { get; private set; }

        [field: SerializeField]
        public float MaxSpeed { get; private set; }

        [field: SerializeField]
        public float Deceleration { get; private set; }
    }
}
