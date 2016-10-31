using UnityEngine;
using System.Collections;

public class BGController : MonoBehaviour {
	[SerializeField]
	private float speed;

	private Transform myTransform;
	private Vector2 currentPosition;

	// Use this for initialization
	void Start () {
		myTransform = gameObject.GetComponent<Transform> ();
		currentPosition = myTransform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		currentPosition -= new Vector2 (speed, 0);
		myTransform.position = currentPosition;
		reset ();
	}
	void reset(){
		if(currentPosition.x <-14.0f)
			currentPosition=new Vector2(0,0);
		
	}
}
