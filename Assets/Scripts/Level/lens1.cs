using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lens1 : MonoBehaviour
{
    public Transform firepoint;
    public Rigidbody2D bullet;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag != "LightOrb") return;

        Rigidbody2D clone;
        clone = (Rigidbody2D)Instantiate(bullet, firepoint.position, firepoint.rotation);

        clone.velocity = Vector3.right * 5f;


    }
}