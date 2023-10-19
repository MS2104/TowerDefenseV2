using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [Header("Wave info")]
    [SerializeField] private int currentWaveNumber, currentWaveSize, enemiesSpawned, enemiesAlive;

    float spawnInterval = 2f;

    public Transform spawnpoint;
    public GameObject[] enemyObj;

    // Start is called before the first frame update
    private void Awake()
    {
        currentWaveSize += 5;
        currentWaveNumber = 1;
    }

    // Update is called once per frame
    void Update()
    {
        spawnEnemy();

        if (enemiesSpawned == currentWaveSize && enemiesAlive == 0)
        {
            currentWaveNumber++;
        }
    }

    IEnumerator spawnEnemy()
    {
        while (enemiesSpawned <= currentWaveSize)
        {
            
            Instantiate(enemyObj[0], spawnpoint.position, Quaternion.identity);
            enemiesSpawned++;
            yield return new WaitForSeconds(spawnInterval);

            if (currentWaveNumber >= 10)
            {
                Debug.Log("Wave 10 reached. Upgrading enemies.");
            }

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
