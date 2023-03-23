using UnityEngine;

namespace Pawn.Controller2D
{
    public class PawnControllerInput : MonoBehaviour, IPawnControllerInput
    {
        [field: SerializeField]
        public float Move { get; set; }

        [field: SerializeField]
        public bool JumpPressed { get; set; }

        [field: SerializeField]
        public bool JumpPerformed { get; set; }

        [field: SerializeField]
        public bool JumpReleased { get; set; }

        [field: SerializeField]
        public bool Interact { get; set; }

        [field: SerializeField]
        public bool Dash { get; set; }
    }
}
