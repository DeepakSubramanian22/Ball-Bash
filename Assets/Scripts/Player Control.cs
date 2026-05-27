using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody PlayerRB;
    private GameObject focalPoint;
    public float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerRB=GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float playerInput = Input.GetAxis("Vertical");
        PlayerRB.AddForce(focalPoint.transform.forward * (speed * playerInput));
    }
}
