using UnityEngine;

[CreateAssetMenu(fileName = "DashStyle_", menuName = "DashStyle")]
public class DashStyle : ScriptableObject
{
    [field: SerializeField]
    public float DashCooldown { get; private set; } = 0.1f;

    [field: SerializeField]
    public float InitialDashForce { get; private set; } = 5.0f;

    [field: SerializeField]
    public float DashDecayRate { get; private set; } = 2.0f;
}
