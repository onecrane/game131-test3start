using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Wibble : MonoBehaviour
{

    public int wibbleValue = 88;
    public int wobbleValue = 324;

    void Start()
    {
        print(string.Format("I wibble {0} and wobble {1}", wibbleValue, wobbleValue));
    }


    void Update()
    {
        
    }
}
