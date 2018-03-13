using UnityEngine;

public class FallDetector : MonoBehaviour
{
    private bool _isFallDetected = false;

    public SpawnArea TrampolineSpawnArea;

    public int EnemiesCount = 1000;

    public GameObject EnemyToSpawn;

    public float SpawnDelay = 2f;

    void OnTriggerEnter(Collider collider)
    {
        if (!_isFallDetected && collider.CompareTag("Player"))
        {
            _isFallDetected = true;

            for (int i = 0; i < EnemiesCount; i++)
            {
                TrampolineSpawnArea.Spawn(EnemyToSpawn);
            }

            InvokeRepeating(nameof(Spawn), SpawnDelay, SpawnDelay);
        }
    }

    void Spawn()
    {
        TrampolineSpawnArea.Spawn(EnemyToSpawn);
    }
}
