﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour {

    public Rigidbody rb;
	public float velocity = -1;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.velocity = new Vector3(0, velocity, 0);
	}
}
