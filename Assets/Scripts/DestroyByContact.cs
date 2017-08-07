using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerExplosion;
	private int scoreValue;
	private GameController gameController;

	void Start(){
		GameObject gameControllerO = GameObject.FindWithTag ("GameController"); 
		Debug.Log ("gameC");
		if(gameControllerO != null){
			gameController = gameControllerO.GetComponent<GameController> ();
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Boundary") {
			return;
		}
		Instantiate(explosion, transform.position, transform.rotation);
		if(other.tag == "Player"){
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
		}
		gameController.AddScore (scoreValue);
		Destroy(other.gameObject);
		Destroy (gameObject);
	}
}
