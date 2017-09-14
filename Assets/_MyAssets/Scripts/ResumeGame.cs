using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeGame : MonoBehaviour {

	public void ResumeTheGame () {
		PlayerController playerController = FindObjectOfType<PlayerController>();
		playerController.transform.position = playerController.initialPosition;
		Manager.gameOver = false;
		Time.timeScale = 1;
	}
}
