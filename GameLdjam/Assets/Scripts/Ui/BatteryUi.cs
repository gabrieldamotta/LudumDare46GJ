﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryUi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float LigthDecay(float p){
        return Mathf.Pow(p, (3/2));
    }
}
