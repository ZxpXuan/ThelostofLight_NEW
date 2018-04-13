using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class triggerele : MonoBehaviour
{
    [SerializeField]
    UnityEvent OnTrigger;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag != "LightOrb") return;

        print("Trigger");

       OnTrigger.Invoke();
    }

}
