using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemyCount;
    public int waveNumber;
    private float spawnPos = 9.0f;

    public GameObject powerUpPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(powerUpPrefab, generateRandomPos(), Quaternion.identity);
        SpawnEnemyWave(waveNumber);
      
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;

        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Instantiate(powerUpPrefab, generateRandomPos(), Quaternion.identity);
        }
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab , generateRandomPos(), Quaternion.identity);
        }
    }
    
    private Vector3 generateRandomPos()
    {
        float spawmx = Random.Range(-spawnPos, spawnPos);
        float spawnZ = Random.Range(-spawnPos, spawnPos);
        
        Vector3 randomPos = new Vector3(spawmx, 0, spawnZ);
        return randomPos;
    }
}
