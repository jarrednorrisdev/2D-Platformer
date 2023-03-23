using UnityEngine;

namespace Utilities
{
    public static class Vector2Helper
    {
        public static Vector2 GetVectorFromBearing(float bearing)
        {
            // Convert bearing angle from degrees to radians
            float radians = bearing * Mathf.Deg2Rad;

            // Calculate x and y components of vector using trigonometry
            float x = Mathf.Cos(radians);
            float y = Mathf.Sin(radians);

            // Normalize the vector and return it
            return new Vector2(x, y).normalized;
        }
    }
}
