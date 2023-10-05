using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject[] targetPoints;
    public float speed = 5.0f;
    private int currentTargetIndex = 0;

    void Update()
    {
        if (currentTargetIndex < targetPoints.Length)
        {
            Vector3 targetPosition = targetPoints[currentTargetIndex].transform.position;
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

            if (Vector3.Distance(transform.position, targetPosition) < 0.001f)
            {
                currentTargetIndex++;
            }
        }
    }
}
