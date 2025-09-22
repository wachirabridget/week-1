using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float propellerSpeed = 1000f;

    void Update()
    {
        // Spin around Z-axis
        transform.Rotate(Vector3.forward * propellerSpeed * Time.deltaTime);
    }
}
