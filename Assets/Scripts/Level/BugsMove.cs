using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugsMove : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        RandomMove();
    }

    void RandomMove()
    {
        gameObject.transform.Rotate(0, 0, RandomNumber()*Time.deltaTime*360, Space.Self);
        gameObject.transform.Translate(0, Random.value * Time.deltaTime*8, 0, Space.Self);
    }

    float RandomNumber()
    {
        float num=Random.value;
        if (Random.value >= 0.5) num = -1 * num;
        return num;
    }
}
