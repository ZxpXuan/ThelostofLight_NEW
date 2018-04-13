using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fens : MonoBehaviour
{

    
    // Use this for initialization
    void Start()
    {


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag != "LightOrb") return;
        Destroy(gameObject);
    }
    
}
