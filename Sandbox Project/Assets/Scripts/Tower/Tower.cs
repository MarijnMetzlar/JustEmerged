using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {

	void Update ()
	{
		gameObject.GetComponent<Transform> ().Rotate (Vector3.right + Vector3.up * 3);
	}

	void OnTriggerEnter(Collider other)
	{
		Application.LoadLevel ("World 1");
	}
}
