using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public float spawnInterval = 2f;
    public Transform[] spawnPoints;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1f, spawnInterval);
    }

    void SpawnObstacle()
    {
        int randIndex = Random.Range(0, spawnPoints.Length);
        int randObstacle = Random.Range(0, obstaclePrefabs.Length);
        Instantiate(obstaclePrefabs[randObstacle], spawnPoints[randIndex].position, Quaternion.identity);
    }
}
