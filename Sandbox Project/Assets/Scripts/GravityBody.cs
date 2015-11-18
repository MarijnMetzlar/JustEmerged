using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]

public class GravityBody : MonoBehaviour {

	//added to every object that is on the world

	GravityAttractor planet;

	void Awake()
	{
		planet = GameObject.FindGameObjectWithTag ("Planet").GetComponent<GravityAttractor> ();
		GetComponent<Rigidbody> ().useGravity = false;
		GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeRotation;
	}

	void FixedUpdate()
	{
		planet.Attract (transform);
	}
}
