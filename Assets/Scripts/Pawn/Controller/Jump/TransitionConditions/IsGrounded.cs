using UnityEngine;

[CreateAssetMenu(
    fileName = "Condition_IsGrounded",
    menuName = "StateSystem/Jump/Conditions/IsGrounded"
)]
public class IsGrounded : TransitionCondition<PawnJumpContext>
{
    [SerializeField]
    int numberOfRays = 3;

    [SerializeField]
    float rayLength = 0.1f;

    protected override bool EvaluateCondition(PawnJumpContext context)
    {
        // return Physics2D.OverlapCircle(
        //     context.GroundCheck.position,
        //     context.GroundCheckRadius,
        //     context.GroundLayer
        // );

        Bounds bounds = context.Collider.bounds;
        float width = bounds.size.x;
        float startY = bounds.min.y;
        Vector2 origin = new Vector2(
            bounds.min.x,
            startY
        );

        for (int i = 0; i < numberOfRays; i++)
        {
            RaycastHit2D hit = Physics2D.Raycast(
                origin,
                Vector2.down,
                rayLength,
                context.GroundLayer
            );

            Debug.DrawRay(origin, Vector2.down * rayLength, Color.red);

            if (hit.collider != null)
            {
                return true;
            }

            origin.x += width / (numberOfRays - 1);
        }

        return false;
    }

    public IsGrounded()
    {
        ConditionDisplayString =
            @"
        float width = context.CharacterCollider.bounds.size.x;
        float startY = context.CharacterCollider.bounds.min.y;
        Vector2 origin = new Vector2(context.CharacterCollider.bounds.min.x, startY);

        for (int i = 0; i < numberOfRays; i++)
        {
            RaycastHit2D hit = Physics2D.Raycast(
                origin,
                Vector2.down,
                rayLength,
                context.GroundLayer
            );

            Debug.DrawRay(origin, Vector2.down * rayLength, Color.red);

            if (hit.collider != null)
            {
                return true;
            }

            origin.x += width / (numberOfRays - 1);
        }

        return false;
        ";
    }
}
