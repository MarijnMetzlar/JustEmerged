using UnityEngine;
using System.Collections;

public class LavaBoss : MonoBehaviour {

	public float targetDistance;
	public float enemyMovementSpeed;
	public float damping;

	void Update () 
	{
		LookAtPlayer ();
		Walk ();
	}

	void LookAtPlayer()
	{
		Quaternion rotation = Quaternion.LookRotation (GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>().position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * damping);
		
//		Vector3 playerPosition = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ().position;
//		gameObject.transform.LookAt (playerPosition);
	}

	void Walk ()
	{
		transform.Translate (Vector3.forward * enemyMovementSpeed * Time.deltaTime);
	}
}
