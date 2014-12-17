﻿using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

	public GameObject[] obj;
	public GameObject[] obj2;
	public GameObject door;
	public float platformSize = 15.0f;
	public float z = -5.0f;
	public int numberOfPlatformsToInvoke = 4;
	
	private bool firstDoor;

	// Use this for initialization
	void Start () {
		firstDoor = true;
		Spawn ();
	}

	void Spawn() {
		for (int i = 0; i < numberOfPlatformsToInvoke; ++i) {
			z += platformSize;
			if (z > 150.0f) {
					int range = Random.Range (0, obj2.Length);
				if (firstDoor) {
					Debug.Log ("z1: " + z);
					float aux = z;
					aux += platformSize/4;
					Debug.Log ("z2: " + z);
					Instantiate (obj2 [range], new Vector3 (transform.position.x, transform.position.y, aux), obj2 [range].transform.rotation);
					firstDoor = false;
				} else
					Instantiate (obj2 [range], new Vector3 (transform.position.x, transform.position.y, z), obj2 [range].transform.rotation);
			}
			else {
				int range = Random.Range (0, obj.Length);
					Instantiate (obj [range], new Vector3 (transform.position.x, transform.position.y, z), obj [range].transform.rotation);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.parent.gameObject.transform.position.z >= (z-(platformSize*4)))
			Spawn ();
	}
}