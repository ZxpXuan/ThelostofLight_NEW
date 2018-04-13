using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class win : MonoBehaviour {
    public UnityEvent continu;
    public float t;
    public AudioSource winsound;
    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    IEnumerator OnCollisionEnter2D(Collision2D collision)
    {



        if (collision.collider.tag == "player")
        {
            yield return new WaitForSeconds(1);
            winsound.Play();
            yield return new WaitForSeconds(t);
            continu.Invoke();
            yield return new WaitForSeconds(5);
            loadscene();

        }
       
    }
    void loadscene()
    {
        Application.LoadLevel(0);
    }
}
