using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float poisonDamage = 125.5f;
        Debug.Log(poisonDamage);
        float Health = 1004f; 
        Debug.Log(Health);

        while (Health > 0)
        {
            Debug.Log(Health);
            Health = Health - poisonDamage;
        }
        if ( Health <= 0 )
        {
            Debug.Log(Health);
            print("player is unalived ");
        }
       




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
