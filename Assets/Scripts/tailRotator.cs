using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tailRotator : MonoBehaviour {

	public float rotationSteps;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float rotate = transform.rotation.x + rotationSteps;
		transform.Rotate(rotate,transform.rotation.y,transform.rotation.z);
	}
}
