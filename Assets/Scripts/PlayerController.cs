using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	private float speed;

	private Transform myTransform;
	private Vector2 myPosition;



	// Use this for initialization
	void Start () {

		myTransform = gameObject.GetComponent<Transform>();
		myPosition = myTransform.position;
	}

	// Update is called once per tick
	void FixedUpdate () {
		 float myInput;
		 float myInput1;
		myInput = Input.GetAxis ("Vertical");
		myInput1 = Input.GetAxis ("Horizontal");
		myPosition = myTransform.position;
		//move up
		if (myInput > 0) {
			myPosition += new Vector2 (0,speed);
		}
		//move down
		if (myInput < 0) {
			myPosition -= new Vector2 (0, speed);
		}
		//move right
		if (myInput1 > 0) {
			myPosition += new Vector2 (speed,0);
		}
		//move left
		if (myInput1 < 0) {
			myPosition -= new Vector2 (speed,0);
		}
		//fix bounds

		checkBounds ();
		myTransform.position = myPosition;
	}


	private void checkBounds(){
		if (myPosition.x < -18.0f) {
			myPosition.x = -18.0f;
		}
		if (myPosition.x > 18.0f) {
			myPosition.x = 18.0f;
		}

		if (myPosition.y < -6.0f) {
			myPosition.y = -6.0f;
		}
		if (myPosition.y > -1.3f) {
			myPosition.y = -1.3f;
		}
	}

}
