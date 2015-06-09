using UnityEngine;
using System.Collections;

public class Vector_Simple : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public float moveSpeed = 10f;
	
	void Update () {

		// Adding Time.deltaTime will move in m/s isntead of meters/frame
		// Using Input.GetButton is better because it can be reassigned
		if(Input.GetButton("Jump"))
		{
			transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
			Debug.Log ("UP");
		}
		if(Input.GetAxis("Horizontal") > 0)
		{
			transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
			Debug.Log ("RIGHT");
		}
		if(Input.GetButton ("Vertical"))
		{
			transform.Translate(Vector2.up * -moveSpeed * Time.deltaTime);
			Debug.Log ("DOWN");
		}
		if(Input.GetAxis("Horizontal") < 0)
		{
			transform.Translate(Vector2.right * -moveSpeed * Time.deltaTime);
			Debug.Log ("LEFT");
		}

	}
	
	void FixedUpdate() {
		

		}
}
