using System;
using System.Collections;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody PlayerRB;
    private GameObject focalPoint;
    public float speed = 5.0f;
    public bool hasPowerUp = false;
    public GameObject PowerUpIndicator;
    private float powerUp = 15;
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
        PowerUpIndicator.transform.position = transform.position + new Vector3(0,-0.5f,0);
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            PowerUpIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(powerUpCountdownRoutine());
        }
    }

    IEnumerator powerUpCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerUp = false;
        PowerUpIndicator.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            Rigidbody enemyRb  = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 AwayfromPlayer = collision.gameObject.transform.position - transform.position;
            
            enemyRb.AddForce(AwayfromPlayer * powerUp , ForceMode.Impulse);
            Debug.Log("Collided with " + collision.gameObject.name + "With the Powerup Set to" + hasPowerUp);
        }
    }
}
