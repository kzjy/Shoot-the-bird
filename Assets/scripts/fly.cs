using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour {

    public Vector3 direction1;
    public int speed;

	// Use this for initialization
	void Start () {

        Destroy(gameObject, 5);
        
        
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(direction1 * speed * Time.deltaTime);


	}
}
