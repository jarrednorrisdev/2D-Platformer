using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPawnControllerInput : MonoBehaviour, IPawnControllerInput
{
    [field: SerializeField] public PlayerInput PlayerInput { get; private set; }
    [field: SerializeField] public InputAction MoveAction { get; private set; }
    [field: SerializeField] public InputAction JumpAction { get; private set; }
    [field: SerializeField] public InputAction InteractAction { get; private set; }
    [field: SerializeField] public InputAction DashAction { get; private set; }

    void OnEnable()
    {
        MoveAction = PlayerInput.actions.FindAction("Move");
        JumpAction = PlayerInput.actions.FindAction("Jump");
        InteractAction = PlayerInput.actions.FindAction("Interact");
        DashAction = PlayerInput.actions.FindAction("Dash");

        MoveAction.Enable();
        JumpAction.Enable();
        InteractAction.Enable();
        DashAction.Enable();

        JumpAction.started += context => { Debug.Log("JumpAction Started"); };
    }

    void OnDisable()
    {
        MoveAction.Disable();
        JumpAction.Disable();
        InteractAction.Disable();
        DashAction.Disable();
    }

    public float Move => MoveAction.ReadValue<float>();
    public bool JumpPressed => JumpAction.WasPressedThisFrame();
    public bool JumpPerformed => JumpAction.WasPerformedThisFrame();
    public bool JumpReleased => JumpAction.WasReleasedThisFrame();
    public bool Interact => InteractAction.WasPressedThisFrame();
    public bool Dash => DashAction.WasPressedThisFrame();
}