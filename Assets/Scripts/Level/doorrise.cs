using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class doorrise : MonoBehaviour
{

    public float updistance = 0;
    private bool enableRising = false;
    private float finalheight;
    // Use this for initialization
    void Start()
    {
        finalheight = gameObject.transform.position.y+updistance;
    }

    private void Update()
    {
        if (enableRising && (gameObject.transform.position.y < finalheight))
        {
            transform.Translate(0, updistance * Time.deltaTime, 0);
        }
        if (gameObject.transform.position.y >= finalheight)
        {
            enableRising = false;
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {

        enableRising = true;
        if (collision.collider.tag != "LightOrb") return;
        
       // transform.Translate(0, updistance, 0);

    }
    
}
