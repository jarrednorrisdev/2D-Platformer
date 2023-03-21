using UnityEngine;

[CreateAssetMenu(fileName = "MoveStyle_", menuName = "MoveStyle")]
public class MoveStyle : ScriptableObject
{
    [field: SerializeField]
    public float Speed { get; private set; }

    [field: SerializeField]
    public float Acceleration { get; private set; }

    [field: SerializeField]
    public float MaxSpeed { get; private set; }

    [field: SerializeField]
    public float Deceleration { get; private set; }
}
