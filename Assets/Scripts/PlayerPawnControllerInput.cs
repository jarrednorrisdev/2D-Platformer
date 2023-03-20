using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPawnControllerInput : MonoBehaviour, IPawnControllerInput
{
    [field: SerializeField] public PlayerInput PlayerInput { get; private set; }
    [field: SerializeField] public InputAction MoveAction { get; private set; }
    [field: SerializeField] public InputAction JumpAction { get; private set; }
    [field: SerializeField] public InputAction InteractAction { get; private set; }

    void OnEnable()
    {
        MoveAction = PlayerInput.actions.FindAction("Move");
        JumpAction = PlayerInput.actions.FindAction("Jump");
        InteractAction = PlayerInput.actions.FindAction("Interact");

        MoveAction.Enable();
        JumpAction.Enable();
        InteractAction.Enable();

        JumpAction.started += context => { Debug.Log("JumpAction Started"); };
    }

    void OnDisable()
    {
        MoveAction.Disable();
        JumpAction.Disable();
        InteractAction.Disable();
    }

    public float Move => MoveAction.ReadValue<float>();
    public bool JumpPressed => JumpAction.WasPressedThisFrame();
    public bool JumpPerformed => JumpAction.WasPerformedThisFrame();
    public bool JumpReleased => JumpAction.WasReleasedThisFrame();
    public bool Interact => InteractAction.WasPressedThisFrame();
}