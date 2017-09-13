using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    public float speedJump;
    private Rigidbody rb;
    private Animator animator;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody> ();
        animator = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update () {
        Vector3 movement = new Vector3 (0.0f, speedJump, 0.0f);

        if (Input.GetKeyDown ("space")) {
            animator.SetTrigger ("Jump");
            rb.AddForce (movement);
        }
    }
}

