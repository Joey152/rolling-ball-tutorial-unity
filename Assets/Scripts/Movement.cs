using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

    Rigidbody rb;
    public Text text;
    public float force = 10f;
    int score = 0;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(Input.GetAxisRaw("Horizontal") * force, 0, Input.GetAxisRaw("Vertical") * force);
    }

    void OnTriggerEnter (Collider c)
    {
        text.text = "Score: " + (++score).ToString();
    }
}
