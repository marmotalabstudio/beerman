using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	private Rigidbody rb;
	public  Vector3 initialPosition;
	private Manager manager;
	public AudioSource beer;

	// Use this for initialization
	void Start () {
		manager = GameObject.FindObjectOfType<Manager> ();	
		rb = GetComponent<Rigidbody> ();
		initialPosition = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < -2.5) {
			manager.gameOver = true;
		}
	}

	void OnTriggerEnter(Collider collider) {
		if(collider.gameObject.tag == "Beer") {
			manager.addScore();
			collider.gameObject.transform.position = new Vector3(0, 3, 49);
			beer.Play ();
		}
	}

}
