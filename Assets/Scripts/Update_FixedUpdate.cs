using UnityEngine;
using System.Collections;

public class Update_FixedUpdate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Update Time: " + Time.deltaTime);
	}

	void FixedUpdate() {
		Debug.Log ("FixedUpdate Time: " + Time.deltaTime);
	}
}
