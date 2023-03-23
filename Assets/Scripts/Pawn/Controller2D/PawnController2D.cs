using Pawn.Controller2D.Dash;
using Pawn.Controller2D.Jump;
using Pawn.Controller2D.Move;
using Pawn.Controller2D.WallJump;
using Sirenix.OdinInspector;
using UnityEngine;
using Utilities;

namespace Pawn.Controller2D
{
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
        PawnWallJump pawnWallJump;

        [SerializeField]
        PawnDash pawnDash;

        [field: SerializeField]
        public BoxRaycaster BoxRaycaster { get; private set; }

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
            pawnWallJump = GetComponent<PawnWallJump>();

            if (usePlayerInput && ControllerInput != null)
            {
                _input = ControllerInput;
            }

            pawnJump.Initialize();
            pawnDash.Initialize();
            pawnWallJump.Initialize();
        }

        void Update()
        {
            pawnMovement.OnUpdate();
            pawnJump.OnUpdate();
            pawnDash.OnUpdate();
            pawnWallJump.OnUpdate();
        }

        void FixedUpdate()
        {
            BoxRaycaster.CheckCollisions();
            pawnMovement.OnFixedUpdate();
            pawnJump.OnFixedUpdate();
            pawnDash.OnFixedUpdate();
            pawnWallJump.OnFixedUpdate();
            _rb.velocityY = Mathf.Clamp(_rb.velocityY, -_maxFallSpeed, _maxRiseSpeed);
        }
    }
}
