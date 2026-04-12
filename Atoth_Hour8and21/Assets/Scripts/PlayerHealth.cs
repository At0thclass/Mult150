using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int healthpoints = 3992;
    // Start is called before the first frame update
    void Start()
    {
        healthpoints = UsePotion(healthpoints);
        UnityEngine.Debug.Log("Health after 1 potion: " + healthpoints);

        healthpoints = UsePotion(healthpoints);
        UnityEngine.Debug.Log("Health after 2 potions: " + healthpoints);

        healthpoints = UsePotion(healthpoints);
        UnityEngine.Debug.Log("Health after 3 potions: " + healthpoints);

        healthpoints = UsePotion(healthpoints);
        UnityEngine.Debug.Log("Health after 4 potions: " + healthpoints);
    }
    // Update is called once per frame

    void Update()
    {

    }
    int UsePotion(int Health)
    {
        Health += 400;
        return Health;
    }
}
