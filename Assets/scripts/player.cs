using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

    Ray ray;
    RaycastHit hit;
    public int score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0) {
            ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            Debug.DrawRay(ray.origin, ray.direction * 300, Color.red);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) {
                if (hit.transform.name != "ground")
                if (hit.transform.name != "ground")
                {
                    Destroy(hit.transform.gameObject);
                    score += 1;
                    

                }
            }
        }
       
	}
}
