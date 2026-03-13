using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 2;
        Debug.Log (a);
        int b = 4;
        Debug.Log (b);
        int c = 8;
        Debug.Log (c);
        int sum = a+b+c;
        Debug.Log (sum);

        sum++;
        Debug.Log (sum);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
