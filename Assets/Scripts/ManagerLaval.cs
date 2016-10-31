using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ManagerLaval : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void LoadNewSean(string newSean){
		SceneManager.LoadScene (newSean);
	}
}
