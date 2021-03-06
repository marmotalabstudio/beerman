﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

	public bool gameOver = false;
	public bool win = false;
	private int score = 0;
	public Button playAgainButton;
	public Text scoreText;
	public Text winText;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(gameOver || win) {
			Time.timeScale = 0;
		}

		// update button visibility
		playAgainButton.gameObject.SetActive(gameOver);
		winText.gameObject.SetActive(win);
	}

	public void addScore() {
		// update score HUD
		scoreText.text = "Score: " + (++score);
	}

	public void resetScore() {
		score = 0;
		scoreText.text = "Score: " + score;
	}
	
}
