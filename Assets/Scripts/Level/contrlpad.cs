using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contrlpad : MonoBehaviour {

	// Use this for initialization
	void Start () {
        waitds();

    }
	
	// Update is called once per frame
	
    IEnumerator waitds()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
