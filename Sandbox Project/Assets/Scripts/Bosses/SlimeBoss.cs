using UnityEngine;
using System.Collections;

public class SlimeBoss : MonoBehaviour {
	
	public float targetDistance;
	public float enemyMovementSpeed;
	public float jumpSpeed;
	public float damping;

	private float jumpTimer = 0.0f;
	private float elapsedTime = 0.0f;

	public float spawnDistance;
	public float enemyHeight;

	public GameObject target;
	public Transform blobPrefab;
	
	void FixedUpdate () 
	{
		targetDistance = Vector3.Distance (GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>().position, transform.position);
		
		LookAtPlayer ();
		AttackPlayer ();
		Shoot ();
	}
	
	void LookAtPlayer()
	{
		Quaternion rotation = Quaternion.LookRotation (GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>().position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * damping);
	}
	
	void AttackPlayer()
	{
		transform.Translate (Vector3.forward * enemyMovementSpeed * Time.deltaTime);

		jumpTimer += Time.deltaTime;
		if (jumpTimer >= 5.0f) 
		{
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpSpeed);

			jumpTimer = 0.0f;
		}
	}
	
	void Shoot()
	{
		elapsedTime += Time.deltaTime;
		if (elapsedTime > 1.0f) 
		{
			Vector3 enemyPosition = transform.position + (transform.forward * spawnDistance) + (transform.up * enemyHeight);
			Instantiate (blobPrefab, enemyPosition, transform.rotation);
			elapsedTime = 0.0f;
		}
	}

}
