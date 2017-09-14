using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeGame : MonoBehaviour {

	private Manager manager;

	public void ResumeTheGame () {
		manager = GameObject.FindObjectOfType<Manager> ();	
		PlayerController playerController = FindObjectOfType<PlayerController>();
		playerController.transform.position = playerController.initialPosition;
		manager.resetScore();
		manager.gameOver = false;
		Time.timeScale = 1;
	}
}
