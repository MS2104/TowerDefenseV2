using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;
    float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * new Vector3(0, 2, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();

            if (enemy != null)
            {
                enemy.health -= damage;
                Destroy(gameObject);
            }
        }
    }
}