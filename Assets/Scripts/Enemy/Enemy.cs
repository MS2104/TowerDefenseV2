using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Stats")]
    public int health, damage;

    public int scoreValue;

    WaveManager waveManager;

    void Start()
    {
        waveManager = FindObjectOfType<WaveManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Endpoint"))
        {
            Debug.Log("Damage dealt, destroying enemyObj...");
            GameManager.mainTower.health -= damage;
            waveManager.enemiesAlive--;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
