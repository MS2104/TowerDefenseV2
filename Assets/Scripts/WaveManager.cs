using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField] public int currentWaveNumber, currentWaveSize, enemiesSpawned, enemiesAlive;

    float spawnInterval = 5f;

    public Transform spawnpoint;
    public GameObject[] enemyObj;

    bool intermissionActive;
    int intermissionDuration = 10;
    int intermissionTimeLeft;

    // Start is called before the first frame update
    private void Awake()
    {
        currentWaveSize += 5;
        currentWaveNumber = 1;

        Debug.Log("Wave 1 started. Wave size: 5.");
    }

    // Update is called once per frame
    void Update()
    {
        if (enemiesSpawned < currentWaveSize && Time.time >= spawnInterval)
        {
            StartCoroutine(SpawnEnemy());
            spawnInterval = Time.time + spawnInterval;
        }
        else if (enemiesSpawned == currentWaveSize && enemiesAlive == 0)
        {
            intermissionActive = true;
        }
    }

    IEnumerator SpawnEnemy()
    {
        Instantiate(enemyObj[0], spawnpoint.position, Quaternion.identity);
        Debug.Log("Enemy spawned!");
        enemiesAlive++;
        enemiesSpawned++;
        yield return null;
    }
}
