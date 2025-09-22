using UnityEngine;

public class PlaneController : MonoBehaviour
{
    private float speed = 5.0f;
    private float rotationSpeed = 50f;
   
    private float verticalInput;

    void Update()
    {
        // Get user input
        verticalInput = Input.GetAxis("Vertical");
        // Move the plane forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        // Rotate only when pressing arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
        
    }
}
