using UnityEngine;

public class PickUpItemSpawnManager : MonoBehaviour
{
    public GameObject pickUpPrefab;
    public float spawnRangeX = 20f;
    public float spawnPositionZ = 20f;
    public float pickUpSpeed = 5f;
    public float spawnInterval = 2f;

    private void Start()
    {
        InvokeRepeating("SpawnPickUp", 0f, spawnInterval);
    }

    private void SpawnPickUp()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0f, spawnPositionZ);
        GameObject pickUp = Instantiate(pickUpPrefab, spawnPos, Quaternion.identity);
    }
}