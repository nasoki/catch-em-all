using UnityEngine;

public class RandomSpawnerWithPositions : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float minSpawnInterval = 2.0f;
    public float maxSpawnInterval = 5.0f;
    public float spawnAreaRadius = 5.0f;
    public Transform[] spawnPositions;  // Array of positions to choose from

    private float nextSpawnTime;

    private void Start()
    {
        SetNextSpawnTime();
    }

    private void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnRandomObject();
            SetNextSpawnTime();
        }
    }

    private void SetNextSpawnTime()
    {
        nextSpawnTime = Time.time + Random.Range(minSpawnInterval, maxSpawnInterval);
    }

    private void SpawnRandomObject()
    {
        if (spawnPositions.Length == 0)
        {
            Debug.LogWarning("No spawn positions defined!");
            return;
        }

        Vector3 randomSpawnPosition = spawnPositions[Random.Range(0, spawnPositions.Length)].position;
        Vector3 spawnPosition = randomSpawnPosition + Random.insideUnitSphere * spawnAreaRadius;
        Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
    }
}
