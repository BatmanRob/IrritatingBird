using UnityEngine;
using System.Collections;

public class ManCollider : MonoBehaviour {

	[SerializeField]
	GameObject explosion = null;

	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.tag == "Coin") {


			Player.Instance.Points +=5;

		}  else if(other.gameObject.tag=="Bird"){
			
			//Update health
			Player.Instance.Health = Player.Instance.Health - 20;

			BirdController sp = 
			other.gameObject.GetComponent<BirdController> ();

		
		}

	}

	void OnCollisionEnter2D(Collision2D other){

		Debug.Log ("Collision");
		if (other.gameObject.tag == "Bird") {

			Destroy (other.gameObject);
		}

	}
}


