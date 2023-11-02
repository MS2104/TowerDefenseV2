using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTowerV2 : MonoBehaviour
{
    bool towerAlive = false;
    public int health = 10;
    [SerializeField] GameObject WaveManager;

    // Start is called before the first frame update
    void Start()
    {
        towerAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!towerAlive && health == 0)
        {
            WaveManager.SetActive(false);
            Debug.Log("0 health reached, game has ended.");
            towerAlive = false;
        }
    }
}
