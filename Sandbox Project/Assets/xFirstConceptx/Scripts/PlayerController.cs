using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private float moveSpeed = 15.0f;
	private float rotateSpeed = 2.5f;

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey ("w")) {
			transform.Translate ((Vector3.forward) * moveSpeed * Time.deltaTime);
		}
		
		if (Input.GetKey ("s")) {
			transform.Translate ((Vector3.back) * moveSpeed * Time.deltaTime);
		}
		
		if (Input.GetKey ("a")) {
			transform.Rotate (Vector3.down * rotateSpeed);
		}
		
		if (Input.GetKey ("d")) 
		{
			transform.Rotate (Vector3.up * rotateSpeed);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "ToNextScene") 
		{
			Destroy (other.gameObject);
			//Application.LoadLevel("BossFight");
		}
	}
}
