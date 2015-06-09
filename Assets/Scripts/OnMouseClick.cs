using UnityEngine;
using System.Collections;

public class OnMouseClick : MonoBehaviour {

	public float moveSpeed = 50f;

	void OnMouseDown() {
		Debug.Log ("Clicked");
		rigidbody2D.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (moveSpeed * Time.deltaTime);
	}
}
