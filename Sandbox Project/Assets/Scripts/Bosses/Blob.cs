using UnityEngine;
using System.Collections;

public class Blob : MonoBehaviour {
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 playerPosition = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ().position;
		transform.Translate (Vector3.forward);
	}
}
