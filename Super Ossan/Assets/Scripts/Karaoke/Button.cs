﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	public float speed = 3.0f;
	public KeyCode trigger;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {		
		transform.position += Vector3.left * speed * Time.deltaTime;
	}
}
