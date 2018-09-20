using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowObject : MonoBehaviour {

    public Transform playerT;

    Transform t;
    Vector3 offset;

	// Use this for initialization
	void Start () {
        t = GetComponent<Transform>();
        offset = t.position - playerT.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        t.position = playerT.position + offset;
	}
}
