using UnityEngine;

public class WindmillFan : MonoBehaviour
{
    public float rotationSpeed = 10.0f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
} 