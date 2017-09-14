using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeGame : MonoBehaviour {

	public void ResumeTheGame () {
		PlayerController.resetPosition();
		Manager.gameOver = false;
		Time.timeScale = 1;
	}
}
