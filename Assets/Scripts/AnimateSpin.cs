using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateSpin : MonoBehaviour {

    Transform t;
    public float speed = 2;

	// Use this for initialization
	void Start () {
        t = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
        t.Rotate(speed, speed, speed);
	}
}
