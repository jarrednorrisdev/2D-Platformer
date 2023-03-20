// using UnityEngine;
// using UnityEngine.Serialization;
//
// [System.Serializable]
// public class PawnJump
// {
//     [field: SerializeField]
//     public float initialJumpForce = 5.0f;
//
//     [field: SerializeField]
//     public float maxJumpForce = 10.0f;
//
//     [field: SerializeField]
//     public float jumpForceIncreaseSpeed = 5.0f;
//
//     [field: SerializeField]
//     public LayerMask GroundLayer { get; private set; }
//
//     [field: SerializeField]
//     public Transform GroundCheck { get; private set; }
//
//     [field: SerializeField]
//     public float GroundCheckRadius { get; private set; } = 0.1f;
//
//     [field: SerializeField]
//     public float jumpCooldown = 0.1f;
//
//     [field: SerializeField]
//     public float coyoteTime = 0.1f;
//
//     [field: SerializeField]
//     public Rigidbody2D Rigidbody2D;
//
//     StateMachineController jumpStateMachine;
//
//     private bool _isGrounded;
//     private float _jumpCooldownTimer;
//     private float _coyoteTimer;
//     private bool _isJumping;
//     private bool _isStartingJump;
//     private bool _isEndingJump;
//
//     public void UpdateGroundCheck()
//     {
//         bool wasGrounded = _isGrounded;
//         _isGrounded = Physics2D.OverlapCircle(
//             GroundCheck.position,
//             GroundCheckRadius,
//             GroundLayer
//         );
//
//         bool justGrounded = !wasGrounded && _isGrounded;
//         if (justGrounded)
//         {
//             _jumpCooldownTimer = jumpCooldown;
//         }
//
//         if (_isGrounded)
//         {
//             _coyoteTimer = coyoteTime;
//         }
//         else
//         {
//             _coyoteTimer -= Time.deltaTime;
//         }
//
//         if (_jumpCooldownTimer > 0)
//         {
//             _jumpCooldownTimer -= Time.deltaTime;
//         }
//     }
//
//     public void Jump(bool jumpPerformed, bool jumpReleased)
//     {
//         //if jump button is released then set y velocity to 0
//         bool jumpTerminated = _isJumping && jumpReleased;
//         Debug.Log($"jumpTerminated: {jumpTerminated}");
//         if (jumpTerminated)
//         {
//             _isJumping = false;
//             Rigidbody2D.velocity = new Vector2(
//                 Rigidbody2D.velocity.x,
//                 0
//             );
//         }
//
//         bool jumpIsOnCooldown = _jumpCooldownTimer > 0;
//         bool airborneAndNoCoyoteTime =
//             !_isGrounded && _coyoteTimer <= 0;
//         Debug.Log($"jumpIsOnCooldown: {jumpIsOnCooldown}");
//         Debug.Log(
//             $"airborneAndNoCoyoteTime: {airborneAndNoCoyoteTime}"
//         );
//         if (jumpIsOnCooldown || airborneAndNoCoyoteTime)
//             return;
//         Debug.Log("can Jump");
//         if (!jumpPerformed)
//             return;
//         if (!_isJumping)
//         {
//             _isJumping = true;
//             Rigidbody2D.AddForce(
//                 Vector2.up * initialJumpForce,
//                 ForceMode2D.Impulse
//             );
//         }
//         else
//         {
//             float additionalJumpForce =
//                 jumpForceIncreaseSpeed * Time.deltaTime;
//             Rigidbody2D.AddForce(
//                 Vector2.up * additionalJumpForce,
//                 ForceMode2D.Impulse
//             );
//             Vector2 velocity = Rigidbody2D.velocity;
//             Rigidbody2D.velocity = new Vector2(
//                 velocity.x,
//                 Mathf.Clamp(velocity.y, 0, maxJumpForce)
//             );
//         }
//     }
// }
