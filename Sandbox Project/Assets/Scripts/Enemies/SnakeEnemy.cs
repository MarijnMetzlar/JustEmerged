using UnityEngine;
using System.Collections;

public class SnakeEnemy : MonoBehaviour {

	public float targetDistance;
	public float enemyLookDistance;
	public float attackDistance;
	public float jumpDistance;
	
	public float enemyMovementSpeed;
	public float jumpSpeed;
	public float damping;
	
	private float jumpTimer = 0.0f;
	public float backOffTimer = 6.0f;
	private bool chargeAttack = false;
	private bool hasAttacked = false;
	
	
	void Start ()
	{
		gameObject.GetComponent<Renderer> ().material.color = Color.green;
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		targetDistance = Vector3.Distance (GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>().position, transform.position);
		
		if (targetDistance < enemyLookDistance) 
		{
			LookAtPlayer ();
		} 
		
		if (targetDistance < attackDistance && targetDistance > jumpDistance && hasAttacked == false) 
		{
			Attack ();
		}
		
		if (targetDistance < jumpDistance && hasAttacked == false) 
		{
			Jump();
		}
		
		if (hasAttacked == true) 
		{
			transform.Translate (Vector3.forward * -enemyMovementSpeed * Time.deltaTime);
			
			backOffTimer -= Time.deltaTime;
			if(backOffTimer < 0)
			{
				hasAttacked = false;
				backOffTimer = 6.0f;
			}
		}
	}
	
	void LookAtPlayer()
	{
		Quaternion rotation = Quaternion.LookRotation (GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>().position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * damping);
	}
	
	void Attack()
	{
		transform.Translate (Vector3.forward * enemyMovementSpeed * Time.deltaTime);
	}
	
	void Jump()
	{
		jumpTimer -= Time.deltaTime;
		if (jumpTimer < 0) 
		{
			gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up * jumpSpeed);
			jumpTimer = 1.0f;
			
			chargeAttack = true;
		}
		
		if (chargeAttack == true) 
		{
			transform.Translate (Vector3.forward * enemyMovementSpeed * 3 * Time.deltaTime);
		}
	}
	
	void OnTriggerEnter(Collider other)
	{

		Debug.Log ("ouch");
		//when the player got hit the snail will back off for some time
		chargeAttack = false;
		hasAttacked = true;
	}
}
