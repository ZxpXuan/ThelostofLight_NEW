using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class bo : MonoBehaviour
{
    public Collider2D bullt;



    void Start()
    {
        
    }


    void Update()
    {
    

    }

   

    private void OnCollisionEnter2D(Collision2D collision)
        
    {

        Destroy();
    }
    void Destroy()
    {
       Destroy(gameObject);
   }

    
}