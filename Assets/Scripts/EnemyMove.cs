using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField]

    private Transform spawnpoint;
    public Transform[] waypoints;
    public float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Enemy instantiated.");
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < waypoints.Length; i++)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[i].position, moveSpeed * Time.deltaTime);
        }
    }
}
