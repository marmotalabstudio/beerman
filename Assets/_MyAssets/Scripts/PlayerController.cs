using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (rb.velocity.y < -10) {
			Debug.Log ("morre");
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
