using UnityEngine;
using System.Collections;

public class BirdController : MonoBehaviour {


	[SerializeField]
	private Vector2 speed ;

	private Transform _transform;
	private Vector2 myPosition;

	//direction: positive when moving right, negative when moving left
	private int direction = 1;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform>();
		myPosition = _transform.position;
		Reset ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		myPosition = _transform.position;
		Vector2 currSpeed = new Vector2 (speed.x * direction, speed.y);
		myPosition -= currSpeed;
		_transform.position = myPosition;

		if (myPosition.x <= -16.0 ||myPosition.x >= 16.0) {
			Reset ();
		}

	}

	public void Reset(){
		direction = -direction;
		_transform.localScale = new Vector2 (direction, 1);
		myPosition = new Vector2 (-direction*15,Random.Range(-0.5f,1.0f));
		_transform.position = myPosition;
	}
}
