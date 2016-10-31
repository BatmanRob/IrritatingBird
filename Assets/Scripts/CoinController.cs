using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {


[SerializeField]
private Vector2 speed = Vector2.zero;

private Transform transform;
private Vector2 currentPosition;

//direction: positive when moving right, negative when moving left
private int direction = 1;

// Use this for initialization
void Start () {
	transform = gameObject.GetComponent<Transform>();
	currentPosition = transform.position;
	Reset ();
}

// Update is called once per frame
void FixedUpdate () {
	currentPosition = transform.position;
	Vector2 currSpeed = new Vector2 (speed.x * direction, speed.y);
	currentPosition -= currSpeed;
	transform.position = currentPosition;

	if (currentPosition.y <= -9.0) {
		Reset ();
	}
}

public void Reset(){
	direction = -direction;
	transform.localScale = new Vector2 (direction, 1);
	currentPosition = new Vector2 (direction*6f, 6f);
	transform.position = currentPosition;
}
}


