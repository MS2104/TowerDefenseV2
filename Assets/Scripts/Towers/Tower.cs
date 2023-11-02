using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public int level = 1;
    public int damage = 10;
    public float attackSpeed = 1.0f;

    private new CircleCollider2D collider2D;

    // public GameObject upgradedTowerObj;
    public Cash cashScript;

    private void Start()
    {
        CircleCollider2D collider2D = GetComponent<CircleCollider2D>();

        GameObject gameManagerObject = GameObject.FindWithTag("GameManager");

        cashScript = gameManagerObject.GetComponent<Cash>();

    }
}
