using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallingMethods : MonoBehaviour
{
    // Start is called before the first frame update


    int TakeDamageFromFireball()
    {
        int playerHealth = 100;
        return playerHealth - 5;
    }
    int TakeDamageFromFireball(int damage, int playerHealth)
    {
        return playerHealth - damage;
    }

    void Start()
    {
        // First version - no parameters
        int x = TakeDamageFromFireball();
        print("Player health: " + x);
  

        // Second version - one parameter
        int y = TakeDamageFromFireball(25);
        print("Player health: " + y);

        // Third version - two parameters
        int z = TakeDamageFromFireball(30, 50);
        print("Player health: " + z);
    }

    private int TakeDamageFromFireball(int v)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
