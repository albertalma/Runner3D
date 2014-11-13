﻿using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public float platformSize = 15.0f;
	public float z = -5.0f;
	public float speed = 5.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * (Time.deltaTime)*speed, Space.World);
	}
}
