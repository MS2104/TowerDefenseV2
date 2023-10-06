using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [Header("Wave info")]
    int waveCount = 1;
    int waveSize = 1;
    int enemiesLeft = 1;

    public Transform spawnpoint;
    public GameObject[] enemyObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Object.Instantiate(enemyObj[0], spawnpoint.position, Quaternion.identity);
        }
    }
}
