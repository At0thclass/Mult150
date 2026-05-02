using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    [Header("Line Spawn Settings")]
    public int numberToSpawn = 10;
    public float spacing = 2f;           
    public Vector3 spawnDirection = Vector3.right;  

    void Update()
    {
   
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }

 
        if (Input.GetKeyDown(KeyCode.X))
        {
            SpawnInLine();
        }
    }

    void SpawnInLine()
    {
        if (prefab == null)
        {
            Debug.LogError("Prefab is not assigned!");
            return;
        }

        Vector3 startPosition = transform.position;

        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPos = startPosition + (spawnDirection * spacing * i);
            Instantiate(prefab, spawnPos, transform.rotation);
        }

        Debug.Log($"Spawned {10} prefabs in a line!");
    }
}