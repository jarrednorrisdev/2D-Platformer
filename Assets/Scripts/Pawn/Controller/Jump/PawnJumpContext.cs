using UnityEngine;

[System.Serializable]
public class PawnJumpContext
{
    [field: SerializeField]
    public PawnController2D ParentController { get; private set; }

    [field: SerializeField]
    public Collider2D Collider { get; private set; }

    [field: SerializeField]
    public LayerMask GroundLayer { get; private set; }

    [field: SerializeField]
    public JumpStyle JumpStyle { get; private set; }

    [field: SerializeField]
    public Rigidbody2D Rb;

    public float JumpCooldownTimer { get; set; }
    public float CoyoteTimer { get; set; }
}
