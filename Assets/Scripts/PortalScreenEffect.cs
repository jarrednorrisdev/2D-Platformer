using UnityEngine;

public class PortalScreenEffect : MonoBehaviour
{
    public GameObject leftTrigger;
    public GameObject rightTrigger;

    private BoxCollider2D leftTriggerCollider;
    private BoxCollider2D rightTriggerCollider;

    private void Start()
    {
        leftTriggerCollider = leftTrigger.GetComponent<BoxCollider2D>();
        rightTriggerCollider = rightTrigger.GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other == leftTriggerCollider)
        {
            transform.position = new Vector2(rightTrigger.transform.position.x - 0.5f, transform.position.y);
        }
        else if (other == rightTriggerCollider)
        {
            transform.position = new Vector2(leftTrigger.transform.position.x + 0.5f, transform.position.y);
        }
    }
}