using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShoot : MonoBehaviour
{
    private void Start()
    {
        GameObject enemyObj = GameObject.FindWithTag("Enemy");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Enemy enemyScript = other.GetComponent<Enemy>();

            if (enemyScript != null)
            {
                // Now you can use the methods or variables from the Enemy script
                // enemyScript.health -= 10;
                Debug.Log("Hello!");
            }
            else
            {
                Debug.LogError("Enemy component not found on the object with the 'Enemy' tag.");
            }
        }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, other.transform.position - transform.position, Mathf.Infinity);

        if (hit.collider != null)
        {
            Debug.Log("Enemy hit!");
            Debug.DrawLine(transform.position, hit.point, Color.red, 1.0f);
            // You can now access information about the object hit, like hit.collider.gameObject
        }
    }
}
