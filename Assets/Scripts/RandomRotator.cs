using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

	public float tumble;

	// Use this for initialization
	void Start () {
		Rigidbody rigidbody = GetComponent<Rigidbody>();
		rigidbody.angularVelocity = Random.insideUnitSphere * tumble;
	} 
	
	// Update is called once per frame
	void Update () {
		
	}
}
