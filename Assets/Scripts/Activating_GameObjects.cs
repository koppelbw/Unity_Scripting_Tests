using UnityEngine;
using System.Collections;

public class Activating_GameObjects : MonoBehaviour
{

		public GameObject ParentBomb;

		// Use this for initialization
		void Start ()
		{
				ParentBomb.SetActive (false);
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKey (KeyCode.Space)) {
						if (ParentBomb.activeSelf)
								ParentBomb.SetActive (false);
						else {
								ParentBomb.SetActive (true);
						}
						//yield WaitForSeconds(1);
				}
		}
}