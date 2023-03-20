public interface IPawnControllerInput
{
    float Move { get; }
    bool JumpPressed { get; }
    bool JumpReleased { get; }
    bool JumpPerformed { get; }
    bool Interact { get; }
}