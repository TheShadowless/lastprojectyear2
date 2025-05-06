using UnityEngine;

public class TrackManager : MonoBehaviour
{
    public GameObject trackSegment;
    public Transform spawnPoint;
    public float segmentLength = 30f;
    public int preSpawnCount = 5;

    void Start()
    {
        for (int i = 0; i < preSpawnCount; i++)
        {
            SpawnSegment(i);
        }
    }

    void SpawnSegment(int index)
    {
        Vector3 pos = spawnPoint.position + Vector3.forward * segmentLength * index;
        Instantiate(trackSegment, pos, Quaternion.identity);
    }
}
