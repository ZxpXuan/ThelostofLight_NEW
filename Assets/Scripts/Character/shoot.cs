using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
  
    public Transform firepoint;
   
    public Rigidbody2D bullet;
    
    private float nextFire = 1F;
    
    public float fireRate = 2F;
    private Animator m_animator;
    public AudioSource jiguang;
    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    void Update()
    {
        var bo = false;
        var bo2 = false;
        
        if (Input.GetKeyDown(KeyCode.J) && Time.time > nextFire)
        {
            

            nextFire = Time.time + fireRate;
           
            Rigidbody2D clone;
            clone = (Rigidbody2D)Instantiate(bullet, firepoint.position, firepoint.rotation);
            jiguang.Play();
        
            clone.velocity = Vector3.left * 7f;
            bo2 = true;
        }
        
        if (Input.GetKeyDown(KeyCode.K) && Time.time > nextFire)
        {
            
            nextFire = Time.time + fireRate;
            
            Rigidbody2D clone;
            clone = (Rigidbody2D)Instantiate(bullet, firepoint.position, firepoint.rotation);
          
            jiguang.Play();
            clone.velocity = Vector3.right * 7f;
            bo = true;
        }
        m_animator.SetBool("bo", bo);
        m_animator.SetBool("bo2", bo2);
        
    }
}
