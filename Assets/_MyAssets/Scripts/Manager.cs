using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

	public static bool gameOver = false;
	private static int score = 0;
	public Button playAgainButton;

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

	public static void addScore() {
		Debug.Log("adddddd");
		// recupera scoreText
		//scoreText.text = "Score: " + (++score);
	}
	
}
