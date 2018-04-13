using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finallybo : MonoBehaviour
{
    [SerializeField] public Transform firepoint;
    public Rigidbody2D bullet;
   // public int boshu;
    Rigidbody2D clone;
    Vector2 vec;
    public float yanchi;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "player")
        {
            // while (boshu<=5) {
            yield return new WaitForSeconds(yanchi);
            clone = (Rigidbody2D)Instantiate(bullet, firepoint.position, firepoint.rotation);

                clone.velocity = Vector3.up * 5f*Time.deltaTime*100;
                //load();
                //boshu = boshu+1;

           // }
        }
    }
    //IEnumerator load()
    //{
//yield return new WaitForSeconds(1); //注意等待时间的写法
    //}
}