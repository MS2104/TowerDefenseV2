using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public int level = 1;
    public int damage = 10;

    private int bonusRange = 2;

    private new CircleCollider2D collider2D;

    private void Start()
    {
        CircleCollider2D collider2D = GetComponent<CircleCollider2D>();
    }

    private void Update()
    {
        if (level >= 2)
        {
            collider2D.radius += bonusRange;
            damage *= 2;
        }
    }
}
