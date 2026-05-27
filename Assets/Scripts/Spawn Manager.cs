using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    private float spawnPos = 9.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        Instantiate(enemyPrefab , generateRandomPos(), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    
    private Vector3 generateRandomPos()
    {
        float spawmx = Random.Range(-spawnPos, spawnPos);
        float spawnZ = Random.Range(-spawnPos, spawnPos);
        
        Vector3 randomPos = new Vector3(spawmx, 0, spawnZ);
        return randomPos;
    }
}
