using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArea : MonoBehaviour
{
    public void Spawn(GameObject enemyToSpawn)
    {
        var pos = new Vector3(Random.Range(transform.position.x - transform.localScale.x / 2, transform.position.x + transform.localScale.x / 2),
            transform.position.y,
            Random.Range(transform.position.z - transform.localScale.z / 2, transform.position.z + transform.localScale.z / 2));

        Instantiate(enemyToSpawn, pos, transform.rotation);
    }
}
