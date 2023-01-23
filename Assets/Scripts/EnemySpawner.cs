using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 3.0f;
    public float spawnRadius = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnInterval, spawnInterval);
    }

    private void SpawnEnemy()
    {
        Vector3 spawnPos = transform.position + Random.insideUnitSphere * spawnRadius;
        GameObject enemy = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        enemy.GetComponent<EnemyShooter>().target = Player.instance.transform;
    }

}
