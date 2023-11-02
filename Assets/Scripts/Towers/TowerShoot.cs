using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShoot : MonoBehaviour
{
    public float rotationSpeed = 5.0f;

    public GameObject bulletPrefab;
    public float attackSpeed = 1f;

    Tower towerStats;

    bool attacking = false;
    bool hasAttacked = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        attacking = true;
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Transform enemyTransform = other.transform;
            transform.up = (enemyTransform.position - transform.position).normalized;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            attacking = false;
            transform.rotation = Quaternion.identity;
        }
    }

    private void FixedUpdate()
    {
        while (attacking && !hasAttacked)
        {
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {
        hasAttacked = true;

        Instantiate(bulletPrefab, transform.position, transform.rotation);

        yield return new WaitForSeconds(attackSpeed);
        hasAttacked = false;
    }
}
