using UnityEngine;
using System.Collections;

public class MiniSlime : MonoBehaviour {

	public float targetDistance;
	public float enemyMovementSpeed;
	public float jumpSpeed;
	public float damping;

	private float jumpTimer;

	void Start ()
	{
		GameObject _SlimeBoss = GameObject.FindGameObjectWithTag ("SlimeBoss");
		Physics.IgnoreCollision(_SlimeBoss.GetComponent<Collider>(), GetComponent<Collider>());
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		targetDistance = Vector3.Distance (GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>().position, transform.position);

		LookAtPlayer ();
		Jump ();
	}

	void LookAtPlayer()
	{
		Quaternion rotation = Quaternion.LookRotation (GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>().position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * damping);
	}

	void Jump()
	{
		jumpTimer += Time.deltaTime;
		
		if (jumpTimer >= 3.0f)
		{
			gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up * jumpSpeed);
			
			jumpTimer = 0.0f;
		}
		
		if (gameObject.transform.position.y > 45.0f) 
		{
			transform.Translate (Vector3.forward * enemyMovementSpeed * Time.deltaTime);
		}
	}
}
