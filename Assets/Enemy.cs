using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Stats")]
    [SerializeField] public int health, damage;

    MainTowerV2 target;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Endpoint"))
        {
            GameManager.mainTower.health -= damage;
            Debug.Log("Damage dealt, destroying enemyObj...");
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

    void DamagePlayer()
    {

    }
}
