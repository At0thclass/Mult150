using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    public int collisionCount = 0;
    public bool countOnlyWithTag = false;
    public string requiredTag = "bottom cube";


    public bool showDebugLogs = true;

    void OnCollisionEnter(Collision collision)
    {
        collisionCount++;

        if (showDebugLogs)
        {
            Debug.Log($"Collision #{collisionCount} detected with: {collision.gameObject.name}");
        }
    }
}