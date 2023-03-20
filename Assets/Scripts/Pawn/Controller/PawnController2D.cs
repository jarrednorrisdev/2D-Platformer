using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(Rigidbody2D))]
public class PawnController2D : MonoBehaviour
{
    #region InputType

    [SerializeField]
    bool usePlayerInput = false;

    [field: SerializeField]
    [field: ShowIf("usePlayerInput")]
    public PlayerPawnControllerInput ControllerInput { get; }

    [HideIf("usePlayerInput")]
    [SerializeField]
    PawnControllerInput pawnControllerInput;
    IPawnControllerInput _input;

    #endregion


    [SerializeField]
    PawnMovement movement;

    [SerializeField]
    PawnJump pawnJump;

    

    [SerializeField]
    Rigidbody2D _rb;

    public PawnController2D(PlayerPawnControllerInput controllerInput)
    {
        ControllerInput = controllerInput;
    }

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();

        if (usePlayerInput && ControllerInput != null)
        {
            _input = ControllerInput;
        }
        
        pawnJump.Initialize();
    }

    void Update()
    {
        
        //jump.UpdateGroundCheck();
        //jump.HandleJumpInput(_input.JumpPerformed, _input.JumpReleased);
    }

    void FixedUpdate()
    {
        movement.Move(_input.Move);
        //jump.Jump();
    }
}
