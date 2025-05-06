using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject speedBoostPrefab;
    public Transform[] spawnPoints;

    void Start()
    {
        InvokeRepeating("SpawnItems", 2f, 3f);
    }

    void SpawnItems()
    {
        Transform point = spawnPoints[Random.Range(0, spawnPoints.Length)];
        GameObject item = Random.value > 0.5f ? coinPrefab : speedBoostPrefab;
        Instantiate(item, point.position, Quaternion.identity);
    }
}
