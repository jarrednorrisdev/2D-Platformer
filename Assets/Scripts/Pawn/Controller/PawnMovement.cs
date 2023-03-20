using UnityEngine;

[System.Serializable]
public class PawnMovement
{
    [SerializeField] float speed = 5.0f;
    [SerializeField] Rigidbody2D rb;

    public void Move(float horizontal)
    {
        Vector2 velocity = rb.velocity;
        velocity.x = horizontal * speed;
        rb.velocity = velocity;
    }
}