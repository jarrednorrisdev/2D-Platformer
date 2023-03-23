using System;
using UnityEngine;

namespace Pawn.Controller2D.Move
{
    [System.Serializable]
    public class PawnMovement : MonoBehaviour
    {
        [SerializeField]
        MoveStyle moveStyle;

        [SerializeField]
        Rigidbody2D rb;

        [field: SerializeField]
        public PawnController2D ParentController { get; private set; }

        float _moveDirection;

        public void OnUpdate()
        {
            _moveDirection = ParentController.ControllerInput.Move;
        }

        public void OnFixedUpdate()
        {
            // float targetVelocityX = _moveDirection * moveStyle.Speed;
            // float force =
            //     moveStyle.Acceleration
            //     * Mathf.Sign(targetVelocityX - rb.velocity.x);
            //
            // float absoluteVelocityX = Mathf.Abs(rb.velocity.x);
            // if (absoluteVelocityX <= moveStyle.MaxSpeed)
            // {
            //     rb.AddForce(new Vector2(force, 0f), ForceMode2D.Force);
            // }

            float targetVelocityX = _moveDirection * moveStyle.Speed;
            float force;

            if (Mathf.Abs(_moveDirection) > 0.01f)
            {
                force =
                    moveStyle.Acceleration
                    * Mathf.Sign(targetVelocityX - rb.velocity.x);
            }
            else
            {
                force = -moveStyle.Deceleration * rb.velocity.x;
            }

            if (
                Mathf.Abs(rb.velocity.x) <= moveStyle.MaxSpeed
                || Math.Abs(Mathf.Sign(force) - Mathf.Sign(rb.velocity.x)) < 0.01f
            )
            {
                rb.AddForce(new Vector2(force, 0f), ForceMode2D.Force);
            }
        }
    }
}
