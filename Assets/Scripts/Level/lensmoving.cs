﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lensmoving : MonoBehaviour
{
    public bool enable { get; set; }
    private bool turnStatus=false;
    // Use this for initialization
    void Start()
    {
        enable = false;
        
    }

    public void Rotate()
    {
        if (turnStatus == false)
        {
            transform.rotation = Quaternion.Euler(0, 0, 100);
            turnStatus = true;
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 137);
            turnStatus = false;
        }
    }
}
