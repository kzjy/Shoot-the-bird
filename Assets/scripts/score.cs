using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class score : MonoBehaviour {

    float timer = 60;
    public GameObject system;
    public Text text;
    public player playerscore;

	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;
        playerscore = system.GetComponent<player>();
        int score = playerscore.score;
        text.text = "TIME: " + timer.ToString("0") +  "   " + "SCORE: " + score.ToString("0");
        if (timer <= 0)
        {
            PlayerPrefs.SetInt("score", score);
            Gameover();
        }
	}

    void Gameover()
    {
        SceneManager.LoadScene(2);
    }

    
}
