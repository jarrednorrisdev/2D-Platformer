using UnityEngine;

[System.Serializable]
public class PawnJumpContext
{
    public PawnController2D ParentController { get; private set; }

    [field: SerializeField]
    public float InitialJumpForce { get; } = 5.0f;

    [field: SerializeField]
    public float MaxJumpForce { get; } = 10.0f;

    [field: SerializeField]
    public float JumpForceIncreaseSpeed { get; } = 5.0f;

    [field: SerializeField]
    public LayerMask GroundLayer { get; private set; }

    [field: SerializeField]
    public Transform GroundCheck { get; private set; }

    [field: SerializeField]
    public float GroundCheckRadius { get; private set; } = 0.1f;

    [field: SerializeField]
    public float JumpCooldown { get; set; } = 0.1f;

    [field: SerializeField]
    public float CoyoteTime { get; } = 0.1f;

    [field: SerializeField]
    public Rigidbody2D Rb;

    public float JumpCooldownTimer { get; set; }
    public float CoyoteTimer { get; set; }
}
