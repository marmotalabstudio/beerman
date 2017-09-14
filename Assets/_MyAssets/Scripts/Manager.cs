using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

	public bool gameOver = false;
	private int score = 0;
	public Button playAgainButton;
	public Text scoreText;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(gameOver) {
			Time.timeScale = 0;
		}

		// update button visibility
		playAgainButton.gameObject.SetActive(gameOver);
	}

	public void addScore() {
		// update score HUD
		scoreText.text = "Score: " + (++score);
	}
	
}
