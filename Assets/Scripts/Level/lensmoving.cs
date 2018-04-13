using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lensmoving : MonoBehaviour
{
    public bool enable { get; set; }

    // Use this for initialization
    void Start()
    {
        enable = false;
        
    }

    public void Rotate()
    {
        transform.rotation = Quaternion.Euler(0,0,100);
    }
}
