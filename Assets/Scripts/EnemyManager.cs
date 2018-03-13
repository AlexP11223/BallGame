using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject EnemyToSpawn;

    public float SpawnDelay = 2f;
    
    public SpawnArea[] SpawnAreas;

    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating(nameof(Spawn), SpawnDelay, SpawnDelay);
    }

    void Spawn()
    {
        var spawnArea = SpawnAreas[Random.Range(0, SpawnAreas.Length)];

        spawnArea.Spawn(EnemyToSpawn);
    }
}