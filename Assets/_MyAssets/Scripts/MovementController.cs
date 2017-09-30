using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MovementController : NetworkBehaviour {

    public float speedJump;
	public float chargeSpeed;
    private Rigidbody rb;
    private Animator animator;
	private float chargeLevel;
	private float chargeMaxLimit = 1f;
	private bool isRunning = false;
	public AudioSource jump;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody> ();
        animator = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update () {
        Vector3 movement = new Vector3 (0.0f, speedJump, 0.0f);

		if (Input.GetKeyDown ("space") && gameObject.transform.position.y <= 0.009f && isLocalPlayer) {
            animator.SetTrigger ("Jump");
            rb.AddForce (movement);
			jump.Play ();
        }

		if(Input.GetKey(KeyCode.W) && isLocalPlayer) {
			isRunning = true;
		}

		if (isRunning  && chargeLevel < chargeMaxLimit && isLocalPlayer) {
			chargeLevel += Time.deltaTime * chargeSpeed;
		}

		animator.SetFloat("movement", chargeLevel);

		if (Input.GetKey (KeyCode.A) && isLocalPlayer) {
			animator.SetFloat ("walkWide", -1);
		}

		if (Input.GetKey (KeyCode.D) && isLocalPlayer) {
			animator.SetFloat("walkWide", 1);
		}
			
    }

}

