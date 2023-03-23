using UnityEngine;

namespace Utilities
{
    public static class RaycastHelper
    {
        [System.Serializable]
        public struct BoxRaycastSettings
        {
            public int numberOfRays;
            public float rayLength;
        }

        public static bool BoxRaycast(
            LayerMask collisionLayer,
            Collider2D collider,
            Vector2 direction,
            BoxRaycastSettings? customSettings = null
        )
        {
            BoxRaycastSettings settings;
            if (customSettings.HasValue)
            {
                settings = customSettings.Value;
            }
            else
            {
                settings = new BoxRaycastSettings { numberOfRays = 3, rayLength = 0.1f };
            }
            Bounds bounds = collider.bounds;
            float width = bounds.size.x;
            float height = bounds.size.y;
            float startX = bounds.min.x;
            float startY = bounds.min.y;

            Vector2 origin;
            if (direction == Vector2.left)
            {
                origin = new Vector2(startX, startY);
            }
            else if (direction == Vector2.right)
            {
                origin = new Vector2(bounds.max.x, startY);
            }
            else if (direction == Vector2.up)
            {
                origin = new Vector2(startX, bounds.max.y);
            }
            else if (direction == Vector2.down)
            {
                origin = new Vector2(startX, startY);
            }
            else
            {
                // Debug.LogError("Invalid direction: " + direction);
                return false;
            }

            for (int i = 0; i < settings.numberOfRays; i++)
            {
                RaycastHit2D hit = Physics2D.Raycast(
                    origin,
                    direction,
                    settings.rayLength,
                    collisionLayer
                );

                Debug.DrawRay(origin, direction * settings.rayLength, Color.red);

                if (hit.collider != null)
                {
                    return true;
                }

                if (direction == Vector2.left || direction == Vector2.right)
                {
                    origin.y += height / (settings.numberOfRays - 1);
                }
                else
                {
                    origin.x += width / (settings.numberOfRays - 1);
                }
            }

            return false;
        }
    }
}
