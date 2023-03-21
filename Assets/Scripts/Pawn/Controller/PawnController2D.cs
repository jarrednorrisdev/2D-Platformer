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
    public PlayerPawnControllerInput ControllerInput { get; private set; }

    [HideIf("usePlayerInput")]
    [SerializeField]
    PawnControllerInput pawnControllerInput;
    IPawnControllerInput _input;

    #endregion


    [SerializeField]
    PawnMovement pawnMovement;

    [SerializeField]
    PawnJump pawnJump;

    [SerializeField]
    PawnDash pawnDash;

    [SerializeField]
    Rigidbody2D _rb;

    [SerializeField]
    float _maxFallSpeed = 50f;

    [SerializeField]
    float _maxRiseSpeed = 50f;

    public PawnController2D(PlayerPawnControllerInput controllerInput)
    {
        ControllerInput = controllerInput;
    }

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        pawnMovement = GetComponent<PawnMovement>();
        pawnJump = GetComponent<PawnJump>();
        pawnDash = GetComponent<PawnDash>();

        if (usePlayerInput && ControllerInput != null)
        {
            _input = ControllerInput;
        }

        pawnJump.Initialize();
        pawnDash.Initialize();
    }

    void Update()
    {
        pawnMovement.OnUpdate();
        pawnJump.OnUpdate();
        pawnDash.OnUpdate();
    }

    void FixedUpdate()
    {
        pawnMovement.OnFixedUpdate();
        pawnJump.OnFixedUpdate();
        pawnDash.OnFixedUpdate();
        _rb.velocityY = Mathf.Clamp(
            _rb.velocityY,
            -_maxFallSpeed,
            _maxRiseSpeed
        );
    }
}
