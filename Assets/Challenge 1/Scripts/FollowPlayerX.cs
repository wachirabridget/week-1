using UnityEngine;

public class FollowPlane : MonoBehaviour
{
    public GameObject plane; // Assign the plane in the Inspector
    private Vector3 offset = new Vector3(30, 0, 10);

    void LateUpdate()
    {
        // Make the camera follow the plane with offset
        transform.position = plane.transform.position + offset;

        // Keep camera rotation fixed (side view)
        transform.rotation = Quaternion.Euler(0, -90, 0);
    }
}
