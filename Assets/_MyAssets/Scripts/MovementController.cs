using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    public float speedJump;
	public float chargeSpeed;
    private Rigidbody rb;
    private Animator animator;
	private float chargeLevel;
	private float chargeMaxLimit = 1f;
	private float chargeMinLimit = 0f;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody> ();
        animator = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update () {
        Vector3 movement = new Vector3 (0.0f, speedJump, 0.0f);

        if (Input.GetKeyDown ("space") && rb.velocity.y == 0) {
            animator.SetTrigger ("Jump");
            rb.AddForce (movement);
        }

		if (Input.GetKey(KeyCode.W)  && chargeLevel < chargeMaxLimit) {
			chargeLevel += Time.deltaTime * chargeSpeed;
		}
		else if(chargeLevel > chargeMinLimit){
			chargeLevel -= Time.deltaTime * chargeSpeed;
		}
		animator.SetFloat("movement", chargeLevel);

		if (rb.velocity.y < -10) {
			Debug.Log ("morre");
			Application.LoadLevel(Application.loadedLevel);
		}
    }
}

