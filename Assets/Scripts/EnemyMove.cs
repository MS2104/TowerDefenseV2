using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject[] targetPoints;
    public float speed = 5.0f;
    private int currentTargetIndex = 0;

    bool pathCompleted = false;

    private void Awake()
    {
        GameObject pathObject = GameObject.Find("Path");

        if (pathObject != null )
        {
            Transform[] children = pathObject.GetComponentsInChildren<Transform>();

            GameObject[] childrenArray = new GameObject[children.Length];

            for (int i = 1; i < childrenArray.Length; i++) // Start vanaf 1 om de parent object "Path" over te slaan!!!!!!
            {
                childrenArray[i - 1] = children[i].gameObject;
            }

            targetPoints = new GameObject[childrenArray.Length];
            Array.Copy(childrenArray, targetPoints, childrenArray.Length);
            Array.Resize(ref targetPoints, targetPoints.Length - 1);
        }
    }
    void Update()
    {
        if (currentTargetIndex < targetPoints.Length && !pathCompleted)
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
