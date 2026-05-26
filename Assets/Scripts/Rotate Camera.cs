using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotateSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * (horizontal * rotateSpeed * Time.deltaTime));
    }
}
