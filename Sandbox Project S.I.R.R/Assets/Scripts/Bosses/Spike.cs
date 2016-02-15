using UnityEngine;
using System.Collections;

public class Spike : MonoBehaviour {
	
	private float _speed = 40.0f;
	
	// Update is called once per frame
	void Update () 
	{
		gameObject.transform.Translate (Vector3.forward * _speed * Time.deltaTime);
	}
}