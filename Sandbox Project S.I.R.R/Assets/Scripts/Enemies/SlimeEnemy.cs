using UnityEngine;
using System.Collections;

public class SlimeEnemy : MonoBehaviour {

	public float targetDistance;
	public float enemyLookDistance;
	public float attackDistance;

	public float enemyMovementSpeed;
	public float jumpSpeed;
	public float damping;
	
	private float jumpTimer;
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		targetDistance = Vector3.Distance (GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>().position, transform.position);
		
		if (targetDistance < enemyLookDistance) 
		{
			LookAtPlayer ();
		} 

		if (targetDistance < attackDistance) 
		{
			Jump ();
		}
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
		
		if (gameObject.transform.position.y > 42.0f) 
		{
			transform.Translate (Vector3.forward * enemyMovementSpeed * Time.deltaTime);
		}
	}
}
