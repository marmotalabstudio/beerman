using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	private Rigidbody rb;
	public static Transform initialPosition;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		initialPosition = gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (rb.velocity.y < -10 && !Manager.gameOver) {
			Manager.gameOver = true;
		}
	}
 
	public static void resetPosition() {
		gameObject.transform = initialPosition;
	}
}
