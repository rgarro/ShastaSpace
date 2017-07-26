using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Boundary boundary;
	public float tilt;

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		Rigidbody rigidbody = GetComponent<Rigidbody>();
		rigidbody.velocity = movement * speed;
		rigidbody.position = new Vector3 (
			Mathf.Clamp(rigidbody.position.x,boundary.xMin,boundary.xMax),
			0.0f,
			Mathf.Clamp(rigidbody.position.z,boundary.zMin,boundary.zMax)
		);
		rigidbody.rotation = Quaternion.Euler (0.0f,0.0f,rigidbody.velocity.x * tilt);
	}
}
