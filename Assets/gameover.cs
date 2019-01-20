using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameover : MonoBehaviour {

    int score;
    public Text textscore;


	// Use this for initialization
	void Start () {
        score = PlayerPrefs.GetInt("score");
        textscore.text = "YOUR SCORE: " + score.ToString();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Menu ()
    {
        SceneManager.LoadScene(0);
    }

}
