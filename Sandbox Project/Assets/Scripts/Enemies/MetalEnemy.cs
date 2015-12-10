using UnityEngine;
using System.Collections;

public class MetalEnemy : MonoBehaviour {

	public float targetDistance;
	public float enemyLookDistance;
	public float attackDistance;
	public float enemyMovementSpeed;
	public float damping;
	private float elapsedTime = 0.0f;

	public GameObject target;
	public GameObject testBulletPrefab;
	private float spawnDistance = 1.1f;
	private float enemyHeight = 1.1f;

	void FixedUpdate () 
	{
		targetDistance = Vector3.Distance (GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>().position, transform.position);
		if (targetDistance < enemyLookDistance) 
		{
			//gameObject.GetComponent<Renderer>().material.color = new Color (1.0f, 0.7f, 0.0f);
			LookAtPlayer();
		}
		if (targetDistance < attackDistance) 
		{
			AttackPlayer ();
			Shoot();
		} 
	}

	void LookAtPlayer()
	{
		Quaternion rotation = Quaternion.LookRotation (GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>().position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * damping);
	}

	void AttackPlayer()
	{
		//gameObject.GetComponent<Rigidbody>().AddForce (transform.forward * enemyMovementSpeed);
		transform.Translate (Vector3.forward * enemyMovementSpeed * Time.deltaTime);
		GameObject.FindGameObjectWithTag ("MetalBall").GetComponent<Transform> ().Rotate (Vector3.right * enemyMovementSpeed);
	}

	void Shoot()
	{
		elapsedTime += Time.deltaTime;
		if (elapsedTime >= 5.0f) 
		{
			Vector3 enemyPosition = transform.position + (transform.forward * spawnDistance) + (transform.up * enemyHeight);

			//Instantiate a bullet in the direction of the player
			Instantiate(testBulletPrefab, enemyPosition, transform.rotation);

			elapsedTime = 0.0f;
		}
	}
}
