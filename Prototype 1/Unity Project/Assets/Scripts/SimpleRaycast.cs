using UnityEngine;

public class PlayerToBookRaycast : MonoBehaviour
{
    public Transform book; // Drag your Book object into Inspector
    public float raycastDistance = 10f;

    void Update()
    {
        if (book == null) return;

        // Direction from player to book
        Vector3 direction = (book.position - transform.position).normalized;
        Ray ray = new Ray(transform.position, direction);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, raycastDistance))
        {
            if (hit.transform == book)
            {
                Debug.Log("Raycast hit the Book!");
                // TODO: Do selection action here
            }
        }
    }

    void OnDrawGizmos()
    {
        if (book == null) return;

        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(transform.position, book.position);
    }
}
