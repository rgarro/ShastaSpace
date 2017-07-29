using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mover : MonoBehaviour {

	public float speed;

	void Start ()
	{
		//transform.Rotate(90, 0, 0);
		GetComponent<Rigidbody>().velocity = transform.forward * speed;

	}

}
