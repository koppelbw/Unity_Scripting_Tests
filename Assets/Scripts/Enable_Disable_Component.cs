using UnityEngine;
using System.Collections;

public class Enable_Disable_Component : MonoBehaviour
{

		private SpriteRenderer spriteRenderer;

		// Use this for initialization
		void Start ()
		{
				spriteRenderer = GetComponent<SpriteRenderer> ();

		}
	
		// Update is called once per frame
		void Update ()
		{
				
		}

	void FixedUpdate() {

		if (Input.GetKey (KeyCode.Delete)) {
			spriteRenderer.enabled = !spriteRenderer.enabled;
		}
	}
}
