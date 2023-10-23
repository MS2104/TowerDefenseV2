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
        StartCoroutine(SpawnEnemy());

        if (enemiesSpawned == currentWaveSize && enemiesAlive == 0)
        {
            currentWaveNumber++;
            enemiesSpawned = 0;
        }
    }

    IEnumerator SpawnEnemy()
    {
        Instantiate(enemyObj[0], spawnpoint.position, Quaternion.identity);
        enemiesAlive++;
        enemiesSpawned++;
        yield return new WaitForSeconds(spawnInterval);
    }
}
