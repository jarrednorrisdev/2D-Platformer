using UnityEngine;

namespace Utilities
{
    [System.Serializable]
    public class BoxRaycaster
    {
        [field: SerializeField]
        public Collider2D Collider { get; private set; }

        [field: SerializeField]
        public LayerMask CollisionMask { get; private set; }

        [field: SerializeField]
        public bool Top { get; private set; }

        [field: SerializeField]
        public bool Bottom { get; private set; }

        [field: SerializeField]
        public bool Left { get; private set; }

        [field: SerializeField]
        public bool Right { get; private set; }

        public void CheckCollisions()
        {
            Top = RaycastHelper.BoxRaycast(CollisionMask, Collider, Vector2.up);
            Bottom = RaycastHelper.BoxRaycast(CollisionMask, Collider, Vector2.down);
            Left = RaycastHelper.BoxRaycast(CollisionMask, Collider, Vector2.left);
            Right = RaycastHelper.BoxRaycast(CollisionMask, Collider, Vector2.right);
        }
    }
}
