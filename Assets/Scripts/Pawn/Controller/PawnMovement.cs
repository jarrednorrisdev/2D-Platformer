using UnityEngine;

[System.Serializable]
public class PawnMovement
{
    [SerializeField]
    float speed = 5.0f;

    [SerializeField]
    Rigidbody2D rb;

    public void Move(float horizontal)
    {
        if (Mathf.Abs(rb.velocityX) <= speed + 0.1f)
            rb.velocityX = horizontal * speed;
    }
}
