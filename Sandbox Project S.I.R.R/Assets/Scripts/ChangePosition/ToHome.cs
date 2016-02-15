using UnityEngine;
using System.Collections;

public class ToHome : MonoBehaviour {

	public Transform fadeInPrefab;

	void Update ()
	{
		gameObject.GetComponent<Transform> ().Rotate (Vector3.right + Vector3.up * 3);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			Instantiate (fadeInPrefab, new Vector3(0, 0, 0), Quaternion.identity);
			GameObject.Find("car").GetComponent<Transform>().position = new Vector3(1527.9f, 42.6f, 1461.2f);
		}
	}
}
