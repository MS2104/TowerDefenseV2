using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShoot : MonoBehaviour
{
    public float rotationSpeed = 5.0f;

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
            transform.rotation = Quaternion.identity;
        }
    }
}
